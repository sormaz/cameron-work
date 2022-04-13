namespace ganttChartApp
{
    partial class Form1
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
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem chartToolBarCopyItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarCopyItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem chartToolBarPrintItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem chartToolBarPrintPreviewItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPrintPreviewItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter chartToolBarSplitter2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSplitter();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem2 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            this.chartControl1 = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.sfDataGrid1 = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.btnGenerate = new Syncfusion.WinForms.Controls.SfButton();
            this.btnClearDT = new Syncfusion.WinForms.Controls.SfButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.importFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl1.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.chartControl1.ChartArea.CursorReDraw = false;
            this.chartControl1.IsWindowLess = false;
            // 
            // 
            // 
            this.chartControl1.Legend.Location = new System.Drawing.Point(1387, 81);
            this.chartControl1.Localize = null;
            this.chartControl1.Location = new System.Drawing.Point(12, 35);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryXAxis.Margin = true;
            this.chartControl1.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.chartControl1.PrimaryYAxis.Margin = true;
            this.chartControl1.Size = new System.Drawing.Size(1508, 360);
            this.chartControl1.TabIndex = 0;
            this.chartControl1.Text = "Workstation Schedule";
            // 
            // 
            // 
            this.chartControl1.Title.Name = "Default";
            this.chartControl1.Titles.Add(this.chartControl1.Title);
            this.chartControl1.ToolBar.EnableDefaultItems = false;
            this.chartControl1.ToolBar.Items.Add(chartToolBarSaveItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarCopyItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPrintPreviewItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSplitter2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarPaletteItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarStyleItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarTypeItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarSeries3DItem2);
            this.chartControl1.ToolBar.Items.Add(chartToolBarShowLegendItem2);
            this.chartControl1.VisualTheme = "";
            // 
            // sfDataGrid1
            // 
            this.sfDataGrid1.AccessibleName = "Table";
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sfDataGrid1.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.AllCells;
            this.sfDataGrid1.Location = new System.Drawing.Point(12, 401);
            this.sfDataGrid1.Name = "sfDataGrid1";
            this.sfDataGrid1.PreviewRowHeight = 35;
            this.sfDataGrid1.PreviewRowHeightMode = Syncfusion.WinForms.DataGrid.Enums.PreviewRowHeightMode.Auto;
            this.sfDataGrid1.Size = new System.Drawing.Size(1185, 228);
            this.sfDataGrid1.Style.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.sfDataGrid1.TabIndex = 1;
            this.sfDataGrid1.Text = "sfDataGrid1";
            // 
            // btnGenerate
            // 
            this.btnGenerate.AccessibleName = "Button";
            this.btnGenerate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnGenerate.Location = new System.Drawing.Point(1239, 420);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(227, 74);
            this.btnGenerate.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate New Schedule";
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnClearDT
            // 
            this.btnClearDT.AccessibleName = "Button";
            this.btnClearDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnClearDT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearDT.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnClearDT.Location = new System.Drawing.Point(1239, 500);
            this.btnClearDT.Name = "btnClearDT";
            this.btnClearDT.Size = new System.Drawing.Size(227, 42);
            this.btnClearDT.Style.BackColor = System.Drawing.Color.LightGray;
            this.btnClearDT.TabIndex = 3;
            this.btnClearDT.Text = "Clear Date Table";
            this.btnClearDT.Click += new System.EventHandler(this.btnClearDT_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1532, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFileToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // importFileToolStripMenuItem1
            // 
            this.importFileToolStripMenuItem1.Name = "importFileToolStripMenuItem1";
            this.importFileToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.importFileToolStripMenuItem1.Text = "Open file";
            this.importFileToolStripMenuItem1.Click += new System.EventHandler(this.importFileToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 641);
            this.Controls.Add(this.btnClearDT);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.chartControl1);
            this.Controls.Add(this.sfDataGrid1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sfDataGrid1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl chartControl1;
        private Syncfusion.WinForms.DataGrid.SfDataGrid sfDataGrid1;
        private Syncfusion.WinForms.Controls.SfButton btnGenerate;
        private Syncfusion.WinForms.Controls.SfButton btnClearDT;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem importFileToolStripMenuItem1;
    }
}

