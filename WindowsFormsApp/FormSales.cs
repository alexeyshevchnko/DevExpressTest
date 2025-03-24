using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Contexts;
using WindowsFormsApp.Entitys;

namespace WindowsFormsApp
{
    public partial class FormSales : DevExpress.XtraEditors.XtraForm
    { 
        private List<Product> products;
        private List<Client> clients;
        private DataTable salesItemsTable;

        public FormSales()
        {
            InitializeComponent(); 

        }

        void LoadClients()
        {
            using (var context = new AppDbContext())
            {
                clients = context.Clients.ToList();
            }
        }

        void LoadProducts()
        {
            using (var context = new AppDbContext())
            {
                products = context.Products.ToList();
            }
        }

        private void FormSales_Load_1(object sender, EventArgs e)
        {
            LoadClients();
            LoadProducts();
            deSaleDate.EditValue = DateTime.Now;

            leClient.Properties.DataSource = clients;
            leClient.Properties.DisplayMember = "Name";
            leClient.Properties.ValueMember = "Id";

            salesItemsTable = new DataTable();

            salesItemsTable.Columns.Add("ProductId", typeof(int));
            salesItemsTable.Columns.Add("ProductName", typeof(string));

            var quantityColumn = new DataColumn("Quantity", typeof(int))
            {
                DefaultValue = 1,
                Caption = "Количество"
            };
            salesItemsTable.Columns.Add(quantityColumn);

            var priceColumn = salesItemsTable.Columns.Add("Price", typeof(decimal));
            priceColumn.Caption = "Цена за ед.";

            var totalColumn = salesItemsTable.Columns.Add("Total", typeof(decimal), "Quantity * Price");
            totalColumn.Caption = "Итого";

            gridControl.DataSource = salesItemsTable;

            // Автогенерация колонок
            gridView.PopulateColumns();

            // Скрыть ProductId
            gridView.Columns["ProductId"].Visible = false;

            // Настроить колонку выбора товара
            var productColumn = gridView.Columns["ProductName"];
            productColumn.Caption = "Товар";
            productColumn.OptionsColumn.AllowEdit = true;

            var productRepo = new RepositoryItemLookUpEdit
            {
                DataSource = products,
                DisplayMember = "Name",
                ValueMember = "Name",
                NullText = "Выберите товар"
            };
            productRepo.EditValueChanged += ProductRepo_EditValueChanged;
            productColumn.ColumnEdit = productRepo;

            // Цена — только для чтения
            var priceGridColumn = gridView.Columns["Price"];
            priceGridColumn.Caption = "Цена за ед.";
            priceGridColumn.OptionsColumn.AllowEdit = false;

            // Итого — только для чтения
            var totalGridColumn = gridView.Columns["Total"];
            totalGridColumn.Caption = "Итого";
            totalGridColumn.OptionsColumn.AllowEdit = false;

            // Переименовать колонку количества
            gridView.Columns["Quantity"].Caption = "Количество";

            // Пересчет при изменении Quantity
            gridView.CellValueChanged += GridView_CellValueChanged;

            // Добавляем последнюю колонку с кнопкой "Удалить"
            var deleteColumn = gridView.Columns.AddVisible("Delete", "Удалить");
            deleteColumn.UnboundType = DevExpress.Data.UnboundColumnType.Object;
            deleteColumn.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;

            var deleteButtonRepo = new RepositoryItemButtonEdit
            {
                TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor
            };
            deleteButtonRepo.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Delete;
            deleteButtonRepo.ButtonClick += DeleteButtonRepo_ButtonClick; 

            deleteColumn.ColumnEdit = deleteButtonRepo;
            deleteColumn.OptionsColumn.AllowEdit = true;
            deleteColumn.Visible = true;
            deleteColumn.VisibleIndex = gridView.Columns.Count;
        }

        private void DeleteButtonRepo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            var rowHandle = gridView.FocusedRowHandle;
            if (rowHandle >= 0)
            {
                gridView.DeleteRow(rowHandle);
            }
        }

        private void GridView_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "Quantity")
            {
                var row = gridView.GetDataRow(e.RowHandle);
                if (row != null)
                {
                    var quantity = Convert.ToInt32(row["Quantity"]);
                    var price = Convert.ToDecimal(row["Price"]);
                    //row["Total"] = quantity * price;
                }
            }
        }

        // Пересчет Total при изменении количества
        private void QuantityEditor_EditValueChanged(object sender, EventArgs e)
        {
            var editor = sender as DevExpress.XtraEditors.SpinEdit;
            if (editor != null)
            {
                gridView.PostEditor(); // применяем значение
                var row = gridView.GetFocusedDataRow();
                if (row != null)
                {
                    row["Total"] = (int)row["Quantity"] * (decimal)row["Price"];
                }
            }
        }

        private void ProductRepo_EditValueChanged(object sender, EventArgs e)
        {
            var editor = sender as LookUpEdit;
            if (editor != null)
            {
                gridView.PostEditor();
                var row = gridView.GetFocusedDataRow();
                var selectedProduct = products.FirstOrDefault(x => x.Name == editor.EditValue?.ToString());
                if (selectedProduct != null)
                {
                    row["ProductId"] = selectedProduct.Id;
                    row["Price"] = selectedProduct.Price;
                    //row["Quantity"] = 1; // автоматически ставим Quantity = 1 при выборе товара
                    //row["Total"] = selectedProduct.Price * 1;
                }
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (leClient.EditValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите клиента.");
                return;
            }

            if (salesItemsTable.Rows.Count == 0)
            {
                MessageBox.Show("Добавьте хотя бы один товар.");
                return;
            }

            // Создание нового объекта продажи
            var sale = new Sale
            {
                ClientId = (int)leClient.EditValue,
                SaleDate = deSaleDate.DateTime,
                SaleItems = salesItemsTable.AsEnumerable().Select(row => new SaleItems
                {
                    ProductId = row.Field<int>("ProductId"),
                    Quantity = row.Field<int>("Quantity"),
                    TotalPrice = row.Field<decimal>("Total")
                }).ToList()
            };

            using (var context = new AppDbContext())
            {
                // Добавление продажи в контекст
                context.Sales.Add(sale);
                await context.SaveChangesAsync();

                // Обновление общей стоимости для клиента
                var client = await context.Clients.FindAsync(sale.ClientId);
                if (client != null)
                {
                    client.TotalSales += sale.SaleItems.Sum(item => item.TotalPrice);
                    await context.SaveChangesAsync();
                }

                MessageBox.Show("Продажа успешно сохранена.");
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}