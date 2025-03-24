namespace WindowsFormsApp
{
    partial class PivotGridForm
    {
        private DevExpress.XtraPivotGrid.PivotGridControl pivotGridControl;
        private DevExpress.XtraEditors.SimpleButton filterButton;
        private DevExpress.XtraEditors.DateEdit startDatePicker;
        private DevExpress.XtraEditors.DateEdit endDatePicker;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pivotGridControl = new DevExpress.XtraPivotGrid.PivotGridControl();
            this.filterButton = new DevExpress.XtraEditors.SimpleButton();
            this.startDatePicker = new DevExpress.XtraEditors.DateEdit();
            this.endDatePicker = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // pivotGridControl
            // 
            this.pivotGridControl.Location = new System.Drawing.Point(12, 58);
            this.pivotGridControl.Name = "pivotGridControl";
            this.pivotGridControl.Size = new System.Drawing.Size(760, 354);
            this.pivotGridControl.TabIndex = 0;
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(12, 12);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(75, 23);
            this.filterButton.TabIndex = 1;
            this.filterButton.Text = "Filter";
            this.filterButton.Click += new System.EventHandler(this.FilterButton_Click);
            // 
            // startDatePicker
            // 
            this.startDatePicker.EditValue = null;
            this.startDatePicker.Location = new System.Drawing.Point(93, 9);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDatePicker.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDatePicker.Size = new System.Drawing.Size(100, 26);
            this.startDatePicker.TabIndex = 2;
            // 
            // endDatePicker
            // 
            this.endDatePicker.EditValue = null;
            this.endDatePicker.Location = new System.Drawing.Point(199, 9);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDatePicker.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDatePicker.Size = new System.Drawing.Size(100, 26);
            this.endDatePicker.TabIndex = 3;
            // 
            // PivotGridForm
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.pivotGridControl);
            this.Name = "PivotGridForm";
            this.Text = "Pivot Grid Example";
            ((System.ComponentModel.ISupportInitialize)(this.pivotGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDatePicker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDatePicker.Properties)).EndInit();
            this.ResumeLayout(false);

        }
    }
}