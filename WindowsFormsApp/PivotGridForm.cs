using DevExpress.XtraEditors;
using DevExpress.XtraPivotGrid;
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
using WindowsFormsApp.Services;

namespace WindowsFormsApp
{
    public partial class PivotGridForm : DevExpress.XtraEditors.XtraForm
    {
        private SalesDataService _salesDataService;

        public PivotGridForm()
        {
            InitializeComponent();
            _salesDataService = new SalesDataService(new AppDbContext()); 
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {

            if (startDatePicker.EditValue == null || endDatePicker.EditValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите период для фильтрации.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DateTime startDate = (DateTime)startDatePicker.EditValue;
            DateTime endDate = (DateTime)endDatePicker.EditValue;

            if (startDate > endDate)
            {
                MessageBox.Show("Дата начала не может быть позже даты окончания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            endDate = endDate.Date.AddDays(1).AddTicks(-1);

            FilterSalesByDate(startDate, endDate);
        }


        private void FilterSalesByDate(DateTime startDate, DateTime endDate)
        {
            var filteredSalesData = _salesDataService.GetSalesDataByDate(startDate, endDate);

            var groupedSalesData = filteredSalesData
                .GroupBy(s => new { s.ClientName, s.ProductName })
                .Select(g => new
                {
                    ClientName = g.Key.ClientName,
                    ProductName = g.Key.ProductName,
                    TotalSales = g.Sum(x => x.TotalPrice)
                })
                .ToList();

            pivotGridControl.DataSource = groupedSalesData;

            pivotGridControl.Fields.Clear();

            // Поле для клиентов (строки)
            PivotGridField clientField = new PivotGridField("ClientName", DevExpress.XtraPivotGrid.PivotArea.RowArea)
            {
                Caption = "Client"
            };

            // Поле для товаров (столбцы)
            PivotGridField productField = new PivotGridField("ProductName", DevExpress.XtraPivotGrid.PivotArea.ColumnArea)
            {
                Caption = "Product"
            };

            // Поле для суммы продаж (данные)
            PivotGridField totalSalesField = new PivotGridField("TotalSales", DevExpress.XtraPivotGrid.PivotArea.DataArea)
            {
                Caption = "Total Sales",
                SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Sum
            };

            pivotGridControl.Fields.Add(clientField);
            pivotGridControl.Fields.Add(productField);
            pivotGridControl.Fields.Add(totalSalesField);
        }


    }
}