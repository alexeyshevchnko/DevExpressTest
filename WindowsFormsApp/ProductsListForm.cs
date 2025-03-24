using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp.Contexts;

namespace WindowsFormsApp
{
    public partial class ProductsListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    { 
        private int _productId = -1;
        public ProductsListForm()
        {
            InitializeComponent();
        }

        private void ProductsListForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        void UpdateData()
        {
            using (var context = new AppDbContext())
            {
                gridControlProducts.DataSource = context.Products.ToList();
            }
        }

        private void barInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ProductEditForm form = new ProductEditForm();
            form.mode = EditFormMode.Insert;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.ShowDialog();
            UpdateData();
        }

        private void barUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridViewProducts.FocusedRowHandle < 0)
                return;

            _productId = (int)gridViewProducts.GetFocusedRowCellValue("Id");

            ProductEditForm clietnEditForm = new ProductEditForm(_productId);
            clietnEditForm.mode = EditFormMode.Update;
            clietnEditForm.StartPosition = FormStartPosition.CenterScreen;
            clietnEditForm.ShowDialog();
            UpdateData();
        }

        private void barDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridViewProducts.FocusedRowHandle < 0)
                return;

            _productId = (int)gridViewProducts.GetFocusedRowCellValue("Id");

            using (var context = new AppDbContext())
            {
                var deleteProduct = context.Clients.Add(new Entitys.Client
                {
                    Id = _productId
                });
                deleteProduct.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }

            UpdateData();
        }
    }
 }
