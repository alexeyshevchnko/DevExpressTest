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

namespace WindowsFormsApp
{
    public partial class RibbonForm1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public RibbonForm1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {

            ProductsListForm form = new ProductsListForm();
            form.MdiParent = this.documentManager1.MdiParent;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClientsListForm form = new ClientsListForm();
            form.MdiParent = this.documentManager1.MdiParent;
            form.Show();
        }

        private void btnFormSale_ItemClick(object sender, ItemClickEventArgs e)
        {
             FormSales form = new FormSales();
            form.MdiParent = this.documentManager1.MdiParent;
            form.Show();
        }

        private void btnPivotGrid_ItemClick(object sender, ItemClickEventArgs e)
        {
            PivotGridForm form = new PivotGridForm();
            form.MdiParent = this.documentManager1.MdiParent;
            form.Show();
        }

        private void btnReport_ItemClick(object sender, ItemClickEventArgs e)
        {
            ClientSalesReportForm form = new ClientSalesReportForm();
            form.MdiParent = this.documentManager1.MdiParent;
            form.Show();
        }
    }
}