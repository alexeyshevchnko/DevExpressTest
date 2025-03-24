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
using WindowsFormsApp.Entitys;
using WindowsFormsApp.Services;

namespace WindowsFormsApp
{
    public partial class ClientSalesReportForm : XtraForm
    {
        private SalesDataService _salesDataService;
        private AppDbContext _appDbContext;
        private List<Client> _clients;

        public ClientSalesReportForm()
        {
            InitializeComponent();
            _appDbContext = new AppDbContext();
            _salesDataService = new SalesDataService(_appDbContext);
            LoadClients();
        }

        private void LoadClients()
        {
            _clients = _appDbContext.Clients.ToList(); 
            
            clientComboBox.Properties.DataSource = _clients;
            clientComboBox.Properties.DisplayMember = "Name";  
            clientComboBox.Properties.ValueMember = "Id"; 
        }

        private void GenerateReportButton_Click(object sender, EventArgs e)
        {
            if (clientComboBox.EditValue == null)
            {
                MessageBox.Show("Пожалуйста, выберите клиента.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var startDate = startDatePicker.DateTime;
            var endDate = endDatePicker.DateTime;

            if (startDate == null || endDate == null)
            {
                MessageBox.Show("Пожалуйста, выберите период для отчета.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (startDate > endDate)
            {
                MessageBox.Show("Дата начала не может быть позже даты окончания.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var clientId = (int)clientComboBox.EditValue;
            var reportData = _salesDataService.GetClientSalesReport(clientId, startDate, endDate);

            // Отображаем отчет
            DisplayReport(reportData);
        }

        private void DisplayReport(List<ClientSalesReport> reportData)
        {
            salesReportGridControl.DataSource = reportData;
            salesReportGridControl.Fields.Clear();

            PivotGridField productField = new PivotGridField("ProductName", PivotArea.RowArea)
            {
                Caption = "Product"
            };

            PivotGridField monthField = new PivotGridField("MonthName", PivotArea.ColumnArea)
            {
                Caption = "Month"
            };

            PivotGridField totalSalesField = new PivotGridField("TotalSales", PivotArea.DataArea)
            {
                Caption = "Total Sales",
                SummaryType = DevExpress.Data.PivotGrid.PivotSummaryType.Sum
            };

            salesReportGridControl.Fields.Add(productField);
            salesReportGridControl.Fields.Add(monthField);
            salesReportGridControl.Fields.Add(totalSalesField);
        }

    }
}