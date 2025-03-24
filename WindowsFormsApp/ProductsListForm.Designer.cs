namespace WindowsFormsApp
{
    partial class ProductsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsListForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.btnInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.btnDelete = new DevExpress.XtraBars.BarButtonItem();
            this.barInsert = new DevExpress.XtraBars.BarButtonItem();
            this.barUpdate = new DevExpress.XtraBars.BarButtonItem();
            this.barDelete = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.gridControlProducts = new DevExpress.XtraGrid.GridControl();
            this.gridViewProducts = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.DrawGroupCaptions = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.DrawGroupsBorderMode = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.btnInsert,
            this.btnUpdate,
            this.btnDelete,
            this.barInsert,
            this.barUpdate,
            this.barDelete});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 7;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.ShowApplicationButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowDisplayOptionsMenuButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowExpandCollapseButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowMoreCommandsButton = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersInFormCaption = DevExpress.Utils.DefaultBoolean.False;
            this.ribbon.ShowPageHeadersMode = DevExpress.XtraBars.Ribbon.ShowPageHeadersMode.Hide;
            this.ribbon.ShowPageKeyTipsMode = DevExpress.XtraBars.Ribbon.ShowPageKeyTipsMode.Hide;
            this.ribbon.ShowQatLocationSelector = false;
            this.ribbon.ShowToolbarCustomizeItem = false;
            this.ribbon.Size = new System.Drawing.Size(1386, 199);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Toolbar.ShowCustomizeItem = false;
            this.ribbon.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden;
            this.ribbon.TransparentEditorsMode = DevExpress.Utils.DefaultBoolean.False;
            // 
            // btnInsert
            // 
            this.btnInsert.Caption = "Добавить";
            this.btnInsert.Id = 1;
            this.btnInsert.Name = "btnInsert";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Изменить";
            this.btnUpdate.Id = 2;
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Удалить";
            this.btnDelete.Id = 3;
            this.btnDelete.Name = "btnDelete";
            // 
            // barInsert
            // 
            this.barInsert.Caption = "Добавить";
            this.barInsert.Id = 4;
            this.barInsert.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barInsert.ImageOptions.SvgImage")));
            this.barInsert.Name = "barInsert";
            this.barInsert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barInsert_ItemClick);
            // 
            // barUpdate
            // 
            this.barUpdate.Caption = "Изменить";
            this.barUpdate.Id = 5;
            this.barUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barUpdate.ImageOptions.SvgImage")));
            this.barUpdate.Name = "barUpdate";
            this.barUpdate.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUpdate_ItemClick);
            // 
            // barDelete
            // 
            this.barDelete.Caption = "Удалить";
            this.barDelete.Id = 6;
            this.barDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barDelete.ImageOptions.SvgImage")));
            this.barDelete.Name = "barDelete";
            this.barDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDelete_ItemClick);
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
            this.ribbonPageGroup1.ItemLinks.Add(this.barInsert);
            this.ribbonPageGroup1.ItemLinks.Add(this.barUpdate);
            this.ribbonPageGroup1.ItemLinks.Add(this.barDelete);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "ribbonPageGroup1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 754);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1386, 36);
            // 
            // gridControlProducts
            // 
            this.gridControlProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlProducts.Location = new System.Drawing.Point(0, 199);
            this.gridControlProducts.MainView = this.gridViewProducts;
            this.gridControlProducts.MenuManager = this.ribbon;
            this.gridControlProducts.Name = "gridControlProducts";
            this.gridControlProducts.Size = new System.Drawing.Size(1386, 555);
            this.gridControlProducts.TabIndex = 2;
            this.gridControlProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProducts});
            // 
            // gridViewProducts
            // 
            this.gridViewProducts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colPrice,
            this.colId});
            this.gridViewProducts.GridControl = this.gridControlProducts;
            this.gridViewProducts.Name = "gridViewProducts";
            this.gridViewProducts.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewProducts.OptionsView.ShowAutoFilterRow = true;
            this.gridViewProducts.OptionsView.ShowGroupPanel = false;
            this.gridViewProducts.OptionsView.ShowViewCaption = true;
            this.gridViewProducts.ViewCaption = "Товары";
            // 
            // colName
            // 
            this.colName.Caption = "Наименование";
            this.colName.FieldName = "Name";
            this.colName.MinWidth = 30;
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 1;
            this.colName.Width = 112;
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Цена";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 30;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 2;
            this.colPrice.Width = 112;
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 30;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 112;
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "ribbonPageGroup2";
            // 
            // ProductsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 790);
            this.Controls.Add(this.gridControlProducts);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "ProductsListForm";
            this.Ribbon = this.ribbon;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.ProductsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem btnInsert;
        private DevExpress.XtraBars.BarButtonItem btnUpdate;
        private DevExpress.XtraBars.BarButtonItem btnDelete;
        private DevExpress.XtraGrid.GridControl gridControlProducts;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barInsert;
        private DevExpress.XtraBars.BarButtonItem barUpdate;
        private DevExpress.XtraBars.BarButtonItem barDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}