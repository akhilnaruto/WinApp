namespace eTemple.UI
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.receiptsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dCRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operatorReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poojaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceReportWithAddressesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.designationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printSeriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poojaPrasadamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattiInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pattiOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.batchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateBatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherIncomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hundialsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miscIncomesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vIPPrasadamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMenusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pOCServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkPrintPreview = new System.Windows.Forms.CheckBox();
            this.cmbSlipPrinter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbTokenPrinter = new System.Windows.Forms.ComboBox();
            this.lblLoggedInUser = new System.Windows.Forms.Label();
            this.menuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.Color.Transparent;
            this.menuBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.menuBar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.receiptsToolStripMenuItem,
            this.newTokenToolStripMenuItem,
            this.reportsToolStripMenuItem1,
            this.settingsToolStripMenuItem,
            this.batchToolStripMenuItem,
            this.otherIncomesToolStripMenuItem,
            this.vIPPrasadamToolStripMenuItem,
            this.showMenusToolStripMenuItem,
            this.pOCServiceToolStripMenuItem,
            this.dataEntryToolStripMenuItem});
            this.menuBar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuBar.Size = new System.Drawing.Size(1352, 29);
            this.menuBar.TabIndex = 1;
            // 
            // receiptsToolStripMenuItem
            // 
            this.receiptsToolStripMenuItem.Name = "receiptsToolStripMenuItem";
            this.receiptsToolStripMenuItem.Size = new System.Drawing.Size(80, 25);
            this.receiptsToolStripMenuItem.Text = "&Receipts";
            this.receiptsToolStripMenuItem.Click += new System.EventHandler(this.receiptsToolStripMenuItem_Click);
            // 
            // newTokenToolStripMenuItem
            // 
            this.newTokenToolStripMenuItem.Name = "newTokenToolStripMenuItem";
            this.newTokenToolStripMenuItem.Size = new System.Drawing.Size(100, 25);
            this.newTokenToolStripMenuItem.Text = "&New Token";
            this.newTokenToolStripMenuItem.Click += new System.EventHandler(this.newTokenToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem1
            // 
            this.reportsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dCRToolStripMenuItem,
            this.operatorReportToolStripMenuItem,
            this.poojaToolStripMenuItem,
            this.serviceReportWithAddressesToolStripMenuItem});
            this.reportsToolStripMenuItem1.Name = "reportsToolStripMenuItem1";
            this.reportsToolStripMenuItem1.Size = new System.Drawing.Size(76, 25);
            this.reportsToolStripMenuItem1.Text = "R&eports";
            // 
            // dCRToolStripMenuItem
            // 
            this.dCRToolStripMenuItem.Name = "dCRToolStripMenuItem";
            this.dCRToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.dCRToolStripMenuItem.Text = "&DCR";
            this.dCRToolStripMenuItem.Click += new System.EventHandler(this.dCRToolStripMenuItem_Click);
            // 
            // operatorReportToolStripMenuItem
            // 
            this.operatorReportToolStripMenuItem.Name = "operatorReportToolStripMenuItem";
            this.operatorReportToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.operatorReportToolStripMenuItem.Text = "&Operator Report";
            this.operatorReportToolStripMenuItem.Click += new System.EventHandler(this.operatorReportToolStripMenuItem_Click);
            // 
            // poojaToolStripMenuItem
            // 
            this.poojaToolStripMenuItem.Name = "poojaToolStripMenuItem";
            this.poojaToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.poojaToolStripMenuItem.Text = "&Service Report";
            this.poojaToolStripMenuItem.Click += new System.EventHandler(this.poojaToolStripMenuItem_Click);
            // 
            // serviceReportWithAddressesToolStripMenuItem
            // 
            this.serviceReportWithAddressesToolStripMenuItem.Name = "serviceReportWithAddressesToolStripMenuItem";
            this.serviceReportWithAddressesToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.serviceReportWithAddressesToolStripMenuItem.Text = "S&ervice Report with Addresses";
            this.serviceReportWithAddressesToolStripMenuItem.Click += new System.EventHandler(this.serviceReportWithAddressesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesToolStripMenuItem,
            this.designationsToolStripMenuItem,
            this.rolesToolStripMenuItem,
            this.printSeriesToolStripMenuItem,
            this.poojaPrasadamToolStripMenuItem,
            this.unitsToolStripMenuItem,
            this.pattiInToolStripMenuItem,
            this.pattiOutToolStripMenuItem,
            this.goodsToolStripMenuItem,
            this.printersToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(78, 25);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // employeesToolStripMenuItem
            // 
            this.employeesToolStripMenuItem.Name = "employeesToolStripMenuItem";
            this.employeesToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.employeesToolStripMenuItem.Text = "&Employees";
            this.employeesToolStripMenuItem.Click += new System.EventHandler(this.employeesToolStripMenuItem_Click);
            // 
            // designationsToolStripMenuItem
            // 
            this.designationsToolStripMenuItem.Name = "designationsToolStripMenuItem";
            this.designationsToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.designationsToolStripMenuItem.Text = "Designations";
            this.designationsToolStripMenuItem.Click += new System.EventHandler(this.designationsToolStripMenuItem_Click);
            // 
            // rolesToolStripMenuItem
            // 
            this.rolesToolStripMenuItem.Name = "rolesToolStripMenuItem";
            this.rolesToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.rolesToolStripMenuItem.Text = "&Roles";
            this.rolesToolStripMenuItem.Visible = false;
            this.rolesToolStripMenuItem.Click += new System.EventHandler(this.rolesToolStripMenuItem_Click);
            // 
            // printSeriesToolStripMenuItem
            // 
            this.printSeriesToolStripMenuItem.Name = "printSeriesToolStripMenuItem";
            this.printSeriesToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.printSeriesToolStripMenuItem.Text = "Print &Series";
            this.printSeriesToolStripMenuItem.Click += new System.EventHandler(this.printSeriesToolStripMenuItem_Click);
            // 
            // poojaPrasadamToolStripMenuItem
            // 
            this.poojaPrasadamToolStripMenuItem.Name = "poojaPrasadamToolStripMenuItem";
            this.poojaPrasadamToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.poojaPrasadamToolStripMenuItem.Text = "Ser&vices";
            this.poojaPrasadamToolStripMenuItem.Click += new System.EventHandler(this.poojaPrasadamToolStripMenuItem_Click);
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.unitsToolStripMenuItem.Text = "U&nits";
            this.unitsToolStripMenuItem.Visible = false;
            this.unitsToolStripMenuItem.Click += new System.EventHandler(this.unitsToolStripMenuItem_Click_1);
            // 
            // pattiInToolStripMenuItem
            // 
            this.pattiInToolStripMenuItem.Name = "pattiInToolStripMenuItem";
            this.pattiInToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.pattiInToolStripMenuItem.Text = "Patti &In";
            this.pattiInToolStripMenuItem.Click += new System.EventHandler(this.pattiInToolStripMenuItem_Click);
            // 
            // pattiOutToolStripMenuItem
            // 
            this.pattiOutToolStripMenuItem.Name = "pattiOutToolStripMenuItem";
            this.pattiOutToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.pattiOutToolStripMenuItem.Text = "Patti &Out";
            this.pattiOutToolStripMenuItem.Click += new System.EventHandler(this.pattiOutToolStripMenuItem_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.goodsToolStripMenuItem.Text = "&Goods";
            // 
            // printersToolStripMenuItem
            // 
            this.printersToolStripMenuItem.Name = "printersToolStripMenuItem";
            this.printersToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.printersToolStripMenuItem.Text = "Prin&ters";
            this.printersToolStripMenuItem.Click += new System.EventHandler(this.printersToolStripMenuItem_Click);
            // 
            // batchToolStripMenuItem
            // 
            this.batchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateBatchToolStripMenuItem,
            this.listBatchesToolStripMenuItem});
            this.batchToolStripMenuItem.Name = "batchToolStripMenuItem";
            this.batchToolStripMenuItem.Size = new System.Drawing.Size(60, 25);
            this.batchToolStripMenuItem.Text = "&Batch";
            this.batchToolStripMenuItem.Click += new System.EventHandler(this.batchToolStripMenuItem_Click);
            // 
            // generateBatchToolStripMenuItem
            // 
            this.generateBatchToolStripMenuItem.Name = "generateBatchToolStripMenuItem";
            this.generateBatchToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.generateBatchToolStripMenuItem.Text = "&Generate Batch";
            this.generateBatchToolStripMenuItem.Click += new System.EventHandler(this.generateBatchToolStripMenuItem_Click);
            // 
            // listBatchesToolStripMenuItem
            // 
            this.listBatchesToolStripMenuItem.Name = "listBatchesToolStripMenuItem";
            this.listBatchesToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.listBatchesToolStripMenuItem.Text = "&List Batches";
            this.listBatchesToolStripMenuItem.Visible = false;
            // 
            // otherIncomesToolStripMenuItem
            // 
            this.otherIncomesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hundialsToolStripMenuItem,
            this.miscIncomesToolStripMenuItem});
            this.otherIncomesToolStripMenuItem.Name = "otherIncomesToolStripMenuItem";
            this.otherIncomesToolStripMenuItem.Size = new System.Drawing.Size(124, 25);
            this.otherIncomesToolStripMenuItem.Text = "&Other Incomes";
            // 
            // hundialsToolStripMenuItem
            // 
            this.hundialsToolStripMenuItem.Name = "hundialsToolStripMenuItem";
            this.hundialsToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.hundialsToolStripMenuItem.Text = "&Hundials";
            this.hundialsToolStripMenuItem.Click += new System.EventHandler(this.hundialsToolStripMenuItem_Click);
            // 
            // miscIncomesToolStripMenuItem
            // 
            this.miscIncomesToolStripMenuItem.Name = "miscIncomesToolStripMenuItem";
            this.miscIncomesToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.miscIncomesToolStripMenuItem.Text = "&Misc Incomes";
            this.miscIncomesToolStripMenuItem.Click += new System.EventHandler(this.miscIncomesToolStripMenuItem_Click);
            // 
            // vIPPrasadamToolStripMenuItem
            // 
            this.vIPPrasadamToolStripMenuItem.Name = "vIPPrasadamToolStripMenuItem";
            this.vIPPrasadamToolStripMenuItem.Size = new System.Drawing.Size(170, 25);
            this.vIPPrasadamToolStripMenuItem.Text = "&VIP (అతిధి సత్కారం)";
            this.vIPPrasadamToolStripMenuItem.Click += new System.EventHandler(this.vIPPrasadamToolStripMenuItem_Click);
            // 
            // showMenusToolStripMenuItem
            // 
            this.showMenusToolStripMenuItem.Name = "showMenusToolStripMenuItem";
            this.showMenusToolStripMenuItem.Size = new System.Drawing.Size(112, 25);
            this.showMenusToolStripMenuItem.Text = "Show Menus";
            this.showMenusToolStripMenuItem.Click += new System.EventHandler(this.showMenusToolStripMenuItem_Click);
            // 
            // pOCServiceToolStripMenuItem
            // 
            this.pOCServiceToolStripMenuItem.Name = "pOCServiceToolStripMenuItem";
            this.pOCServiceToolStripMenuItem.Size = new System.Drawing.Size(107, 25);
            this.pOCServiceToolStripMenuItem.Text = "POC Service";
            this.pOCServiceToolStripMenuItem.Click += new System.EventHandler(this.pOCServiceToolStripMenuItem_Click);
            // 
            // dataEntryToolStripMenuItem
            // 
            this.dataEntryToolStripMenuItem.Name = "dataEntryToolStripMenuItem";
            this.dataEntryToolStripMenuItem.Size = new System.Drawing.Size(94, 25);
            this.dataEntryToolStripMenuItem.Text = "Data Entry";
            this.dataEntryToolStripMenuItem.Click += new System.EventHandler(this.dataEntryToolStripMenuItem_Click);
            // 
            // statusBar
            // 
            this.statusBar.Location = new System.Drawing.Point(0, 711);
            this.statusBar.Name = "statusBar";
            this.statusBar.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusBar.Size = new System.Drawing.Size(1352, 22);
            this.statusBar.TabIndex = 2;
            this.statusBar.Text = "statusBar";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.chkPrintPreview);
            this.panel1.Controls.Add(this.cmbSlipPrinter);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 130);
            this.panel1.TabIndex = 4;
            // 
            // chkPrintPreview
            // 
            this.chkPrintPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chkPrintPreview.AutoSize = true;
            this.chkPrintPreview.Location = new System.Drawing.Point(1176, 103);
            this.chkPrintPreview.Name = "chkPrintPreview";
            this.chkPrintPreview.Size = new System.Drawing.Size(164, 25);
            this.chkPrintPreview.TabIndex = 7;
            this.chkPrintPreview.Text = "Show Print Preview";
            this.chkPrintPreview.UseVisualStyleBackColor = true;
            // 
            // cmbSlipPrinter
            // 
            this.cmbSlipPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbSlipPrinter.FormattingEnabled = true;
            this.cmbSlipPrinter.Location = new System.Drawing.Point(1138, 68);
            this.cmbSlipPrinter.Name = "cmbSlipPrinter";
            this.cmbSlipPrinter.Size = new System.Drawing.Size(208, 29);
            this.cmbSlipPrinter.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1045, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Slip Printer";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::eTemple.UI.Properties.Resources.web;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cmbTokenPrinter);
            this.panel2.Controls.Add(this.lblLoggedInUser);
            this.panel2.Controls.Add(this.menuBar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1352, 111);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1031, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Token Printer";
            // 
            // cmbTokenPrinter
            // 
            this.cmbTokenPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbTokenPrinter.FormattingEnabled = true;
            this.cmbTokenPrinter.Location = new System.Drawing.Point(1140, 36);
            this.cmbTokenPrinter.Name = "cmbTokenPrinter";
            this.cmbTokenPrinter.Size = new System.Drawing.Size(208, 29);
            this.cmbTokenPrinter.TabIndex = 4;
            // 
            // lblLoggedInUser
            // 
            this.lblLoggedInUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLoggedInUser.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedInUser.ForeColor = System.Drawing.Color.Maroon;
            this.lblLoggedInUser.Location = new System.Drawing.Point(1003, 7);
            this.lblLoggedInUser.Name = "lblLoggedInUser";
            this.lblLoggedInUser.Size = new System.Drawing.Size(306, 21);
            this.lblLoggedInUser.TabIndex = 2;
            this.lblLoggedInUser.Text = "logged in user";
            this.lblLoggedInUser.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::eTemple.UI.Properties.Resources.Wood_small;
            this.ClientSize = new System.Drawing.Size(1352, 733);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusBar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuBar;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "eTemple";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poojaPrasadamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattiInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pattiOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printSeriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goodsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem designationsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripMenuItem rolesToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem newTokenToolStripMenuItem;
        private System.Windows.Forms.Label lblLoggedInUser;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dCRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem batchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateBatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listBatchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operatorReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem receiptsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbTokenPrinter;
        private System.Windows.Forms.CheckBox chkPrintPreview;
        private System.Windows.Forms.ComboBox cmbSlipPrinter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem otherIncomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hundialsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miscIncomesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem poojaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vIPPrasadamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceReportWithAddressesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMenusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pOCServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataEntryToolStripMenuItem;
    }
}