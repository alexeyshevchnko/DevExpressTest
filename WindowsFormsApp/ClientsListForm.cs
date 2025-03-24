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
    public partial class ClientsListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private int _clientId = -1;
        public ClientsListForm()
        {
            InitializeComponent();
        }

        private void ClientsListForm_Load(object sender, EventArgs e)
        {
            UpdateData();
        }

        void UpdateData()
        {
            using (var context = new AppDbContext())
            {
                gridControlClients.DataSource = context.Clients.ToList();
            }
        }

        private void barInsert_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClietnEditForm clietnEditForm = new ClietnEditForm();
            clietnEditForm.mode = EditFormMode.Insert;
            clietnEditForm.StartPosition = FormStartPosition.CenterScreen;
            clietnEditForm.ShowDialog();
            UpdateData();
        }

        private void barUpdate_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridViewClients.FocusedRowHandle < 0)
                return;

            _clientId = (int)gridViewClients.GetFocusedRowCellValue("Id");

            ClietnEditForm clietnEditForm = new ClietnEditForm(_clientId);
            clietnEditForm.mode = EditFormMode.Update;
            clietnEditForm.StartPosition = FormStartPosition.CenterScreen;
            clietnEditForm.ShowDialog();
            UpdateData();
        }

        private void gridControlClients_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }

        private void gridControlClients_DoubleClick(object sender, EventArgs e)
        {
            if (gridViewClients.FocusedRowHandle < 0)
                return;

            _clientId = (int)gridViewClients.GetFocusedRowCellValue("Id");

            ClietnEditForm clietnEditForm = new ClietnEditForm(_clientId);
            clietnEditForm.mode = EditFormMode.Update;
            clietnEditForm.StartPosition = FormStartPosition.CenterScreen;
            clietnEditForm.ShowDialog();
            UpdateData();
        }

        private void barDelete_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (gridViewClients.FocusedRowHandle < 0)
                return;

            _clientId = (int)gridViewClients.GetFocusedRowCellValue("Id");

            using (var context = new AppDbContext())
            {
                var deleteClient = context.Clients.Add(new Entitys.Client
                {
                    Id = _clientId
                });
                deleteClient.State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                context.SaveChanges();
            }

            UpdateData();
        }
    }
}