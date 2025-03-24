namespace WindowsFormsApp
{
    partial class ClientSalesReportForm
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
            this.clientComboBox = new DevExpress.XtraEditors.LookUpEdit();
            this.startDatePicker = new DevExpress.XtraEditors.DateEdit();
            this.endDatePicker = new DevExpress.XtraEditors.DateEdit();
            this.generateReportButton = new DevExpress.XtraEditors.SimpleButton();
            this.salesReportGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            ((System.ComponentModel.ISupportInitialize)(this.clientComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportGridControl)).BeginInit();
            this.SuspendLayout();
            // 
            // clientComboBox
            // 
            this.clientComboBox.Location = new System.Drawing.Point(18, 18);
            this.clientComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clientComboBox.Name = "clientComboBox";
            this.clientComboBox.Size = new System.Drawing.Size(300, 26);
            this.clientComboBox.TabIndex = 0;
            // 
            // startDatePicker
            // 
            this.startDatePicker.EditValue = null;
            this.startDatePicker.Location = new System.Drawing.Point(18, 56);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDatePicker.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDatePicker.Size = new System.Drawing.Size(300, 26);
            this.startDatePicker.TabIndex = 1;
            // 
            // endDatePicker
            // 
            this.endDatePicker.EditValue = null;
            this.endDatePicker.Location = new System.Drawing.Point(18, 94);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDatePicker.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDatePicker.Size = new System.Drawing.Size(300, 26);
            this.endDatePicker.TabIndex = 2;
            // 
            // generateReportButton
            // 
            this.generateReportButton.Location = new System.Drawing.Point(18, 132);
            this.generateReportButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(300, 34);
            this.generateReportButton.TabIndex = 3;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.Click += new System.EventHandler(this.GenerateReportButton_Click);
            // 
            // salesReportGridControl
            // 
            this.salesReportGridControl.Location = new System.Drawing.Point(18, 175);
            this.salesReportGridControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.salesReportGridControl.Name = "salesReportGridControl";
            this.salesReportGridControl.OptionsDataField.RowHeaderWidth = 150;
            this.salesReportGridControl.OptionsView.RowTreeOffset = 31;
            this.salesReportGridControl.OptionsView.RowTreeWidth = 150;
            this.salesReportGridControl.Size = new System.Drawing.Size(1140, 585);
            this.salesReportGridControl.TabIndex = 4;
            // 
            // ClientSalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 820);
            this.Controls.Add(this.salesReportGridControl);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.clientComboBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientSalesReportForm";
            this.Text = "Client Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.clientComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salesReportGridControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit clientComboBox;
        private DevExpress.XtraEditors.DateEdit startDatePicker;
        private DevExpress.XtraEditors.DateEdit endDatePicker;
        private DevExpress.XtraEditors.SimpleButton generateReportButton;
        private DevExpress.XtraPivotGrid.PivotGridControl salesReportGridControl;
    }
}