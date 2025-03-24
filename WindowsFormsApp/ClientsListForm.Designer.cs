namespace WindowsFormsApp
{
    partial class ClientsListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsListForm));
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
            this.gridControlClients = new DevExpress.XtraGrid.GridControl();
            this.gridViewClients = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colContactInfo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalSales = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).BeginInit();
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
            this.btnInsert.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnInsert.ImageOptions.SvgImage")));
            this.btnInsert.Name = "btnInsert";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Caption = "Изменить";
            this.btnUpdate.Id = 2;
            this.btnUpdate.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnUpdate.ImageOptions.SvgImage")));
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Удалить";
            this.btnDelete.Id = 3;
            this.btnDelete.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDelete.ImageOptions.SvgImage")));
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
            // gridControlClients
            // 
            this.gridControlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlClients.Location = new System.Drawing.Point(0, 199);
            this.gridControlClients.MainView = this.gridViewClients;
            this.gridControlClients.MenuManager = this.ribbon;
            this.gridControlClients.Name = "gridControlClients";
            this.gridControlClients.Size = new System.Drawing.Size(1386, 555);
            this.gridControlClients.TabIndex = 2;
            this.gridControlClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClients});
            this.gridControlClients.FocusedViewChanged += new DevExpress.XtraGrid.ViewFocusEventHandler(this.gridControlClients_FocusedViewChanged);
            this.gridControlClients.DoubleClick += new System.EventHandler(this.gridControlClients_DoubleClick);
            // 
            // gridViewClients
            // 
            this.gridViewClients.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colContactInfo,
            this.colTotalSales,
            this.colId});
            this.gridViewClients.GridControl = this.gridControlClients;
            this.gridViewClients.Name = "gridViewClients";
            this.gridViewClients.OptionsNavigation.EnterMoveNextColumn = true;
            this.gridViewClients.OptionsView.ShowAutoFilterRow = true;
            this.gridViewClients.OptionsView.ShowGroupPanel = false;
            this.gridViewClients.OptionsView.ShowViewCaption = true;
            this.gridViewClients.ViewCaption = "Клиенты";
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
            // colContactInfo
            // 
            this.colContactInfo.Caption = "Контакты";
            this.colContactInfo.FieldName = "ContactInfo";
            this.colContactInfo.MinWidth = 30;
            this.colContactInfo.Name = "colContactInfo";
            this.colContactInfo.Visible = true;
            this.colContactInfo.VisibleIndex = 2;
            this.colContactInfo.Width = 112;
            // 
            // colTotalSales
            // 
            this.colTotalSales.Caption = "Сумма оказаных услуг";
            this.colTotalSales.FieldName = "TotalSales";
            this.colTotalSales.MinWidth = 30;
            this.colTotalSales.Name = "colTotalSales";
            this.colTotalSales.Visible = true;
            this.colTotalSales.VisibleIndex = 3;
            this.colTotalSales.Width = 112;
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
            // ClientsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 790);
            this.Controls.Add(this.gridControlClients);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IconOptions.ShowIcon = false;
            this.MinimizeBox = false;
            this.Name = "ClientsListForm";
            this.Ribbon = this.ribbon;
            this.ShowInTaskbar = false;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.ClientsListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClients)).EndInit();
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
        private DevExpress.XtraGrid.GridControl gridControlClients;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClients;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colContactInfo;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalSales;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barInsert;
        private DevExpress.XtraBars.BarButtonItem barUpdate;
        private DevExpress.XtraBars.BarButtonItem barDelete;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
    }
}