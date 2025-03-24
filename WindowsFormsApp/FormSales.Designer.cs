using System;

namespace WindowsFormsApp
{
    partial class FormSales
    {
        private System.ComponentModel.IContainer components = null;
        private DevExpress.XtraEditors.LookUpEdit leClient;
        private DevExpress.XtraEditors.DateEdit deSaleDate;
        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.leClient = new DevExpress.XtraEditors.LookUpEdit();
            this.deSaleDate = new DevExpress.XtraEditors.DateEdit();
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.leClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSaleDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSaleDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.SuspendLayout();
            // 
            // leClient
            // 
            this.leClient.Location = new System.Drawing.Point(12, 12);
            this.leClient.Name = "leClient";
            this.leClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leClient.Properties.NullText = "Выберите клиента";
            this.leClient.Size = new System.Drawing.Size(300, 26);
            this.leClient.TabIndex = 0;
            // 
            // deSaleDate
            // 
            this.deSaleDate.EditValue = new System.DateTime(2025, 3, 24, 18, 56, 48, 868);
            this.deSaleDate.Location = new System.Drawing.Point(330, 12);
            this.deSaleDate.Name = "deSaleDate";
            this.deSaleDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSaleDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deSaleDate.Properties.DisplayFormat.FormatString = "g";
            this.deSaleDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deSaleDate.Properties.EditFormat.FormatString = "g";
            this.deSaleDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.deSaleDate.Size = new System.Drawing.Size(200, 26);
            this.deSaleDate.TabIndex = 1;
            // 
            // gridControl
            // 
            this.gridControl.Location = new System.Drawing.Point(12, 50);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Name = "gridControl";
            this.gridControl.Size = new System.Drawing.Size(600, 185);
            this.gridControl.TabIndex = 2;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.gridView.OptionsView.ShowFooter = true;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(23, 241);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(138, 241);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FormSales
            // 
            this.ClientSize = new System.Drawing.Size(630, 400);
            this.Controls.Add(this.leClient);
            this.Controls.Add(this.deSaleDate);
            this.Controls.Add(this.gridControl);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Name = "FormSales";
            this.Text = "Добавить продажу";
            this.Load += new System.EventHandler(this.FormSales_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.leClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSaleDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deSaleDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.ResumeLayout(false);

        }
    }
}