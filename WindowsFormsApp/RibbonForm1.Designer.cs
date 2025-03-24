namespace WindowsFormsApp
{
    partial class RibbonForm1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RibbonForm1));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnProducts = new DevExpress.XtraBars.BarButtonItem();
            this.btnClients = new DevExpress.XtraBars.BarButtonItem();
            this.btnFormSale = new DevExpress.XtraBars.BarButtonItem();
            this.btnPivotGrid = new DevExpress.XtraBars.BarButtonItem();
            this.imageCollection1 = new DevExpress.Utils.ImageCollection(this.components);
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.documentManager1 = new DevExpress.XtraBars.Docking2010.DocumentManager(this.components);
            this.tabbedView1 = new DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView(this.components);
            this.btnReport = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnProducts,
            this.btnClients,
            this.btnFormSale,
            this.btnPivotGrid,
            this.btnReport});
            this.ribbon.LargeImages = this.imageCollection1;
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 6;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(1167, 231);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // btnProducts
            // 
            this.btnProducts.Caption = "Товары";
            this.btnProducts.Id = 1;
            this.btnProducts.ImageOptions.LargeImageIndex = 0;
            this.btnProducts.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnProducts.ImageOptions.SvgImage")));
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // btnClients
            // 
            this.btnClients.Caption = "Клиекты";
            this.btnClients.Id = 2;
            this.btnClients.ImageOptions.LargeImageIndex = 1;
            this.btnClients.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnClients.ImageOptions.SvgImage")));
            this.btnClients.Name = "btnClients";
            this.btnClients.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // btnFormSale
            // 
            this.btnFormSale.Caption = "Продажа";
            this.btnFormSale.Id = 3;
            this.btnFormSale.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnFormSale.ImageOptions.SvgImage")));
            this.btnFormSale.Name = "btnFormSale";
            this.btnFormSale.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnFormSale_ItemClick);
            // 
            // btnPivotGrid
            // 
            this.btnPivotGrid.Caption = "Таблица продаж";
            this.btnPivotGrid.Id = 4;
            this.btnPivotGrid.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPivotGrid.ImageOptions.SvgImage")));
            this.btnPivotGrid.Name = "btnPivotGrid";
            this.btnPivotGrid.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnPivotGrid_ItemClick);
            // 
            // imageCollection1
            // 
            this.imageCollection1.ImageSize = new System.Drawing.Size(32, 32);
            this.imageCollection1.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection1.ImageStream")));
            this.imageCollection1.Images.SetKeyName(0, "download_32x32.png");
            this.imageCollection1.Images.SetKeyName(1, "openhyperlink_32x32.png");
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "ribbonPage1";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnProducts, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnClients, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnFormSale);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnPivotGrid);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnReport);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 659);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1167, 36);
            // 
            // documentManager1
            // 
            this.documentManager1.MdiParent = this;
            this.documentManager1.MenuManager = this.ribbon;
            this.documentManager1.View = this.tabbedView1;
            this.documentManager1.ViewCollection.AddRange(new DevExpress.XtraBars.Docking2010.Views.BaseView[] {
            this.tabbedView1});
            // 
            // btnReport
            // 
            this.btnReport.Caption = "Отчет ";
            this.btnReport.Id = 5;
            this.btnReport.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReport.ImageOptions.SvgImage")));
            this.btnReport.Name = "btnReport";
            this.btnReport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnReport_ItemClick);
            // 
            // RibbonForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 695);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "RibbonForm1";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "RibbonForm1";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.documentManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.Utils.ImageCollection imageCollection1;
        private DevExpress.XtraBars.BarButtonItem btnProducts;
        private DevExpress.XtraBars.BarButtonItem btnClients;
        private DevExpress.XtraBars.Docking2010.DocumentManager documentManager1;
        private DevExpress.XtraBars.Docking2010.Views.Tabbed.TabbedView tabbedView1;
        private DevExpress.XtraBars.BarButtonItem btnFormSale;
        private DevExpress.XtraBars.BarButtonItem btnPivotGrid;
        private DevExpress.XtraBars.BarButtonItem btnReport;
    }
}