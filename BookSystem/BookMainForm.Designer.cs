
namespace BookSystem
{
    partial class BookMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookMainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsrTopMain = new System.Windows.Forms.ToolStrip();
            this.tsrBtnBookInfo = new System.Windows.Forms.ToolStripButton();
            this.tsrReaderInfo = new System.Windows.Forms.ToolStripButton();
            this.tsrBtnBorrowAnnalInfo = new System.Windows.Forms.ToolStripButton();
            this.tsrBtnBorrowReturnInfo = new System.Windows.Forms.ToolStripButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panIndex = new System.Windows.Forms.Panel();
            this.stMain = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借还记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tsrTopMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.stMain.SuspendLayout();
            this.msMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tsrTopMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 81);
            this.panel1.TabIndex = 0;
            // 
            // tsrTopMain
            // 
            this.tsrTopMain.ImageScalingSize = new System.Drawing.Size(80, 60);
            this.tsrTopMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsrBtnBookInfo,
            this.tsrReaderInfo,
            this.tsrBtnBorrowAnnalInfo,
            this.tsrBtnBorrowReturnInfo});
            this.tsrTopMain.Location = new System.Drawing.Point(0, 0);
            this.tsrTopMain.Name = "tsrTopMain";
            this.tsrTopMain.Size = new System.Drawing.Size(942, 67);
            this.tsrTopMain.TabIndex = 1;
            this.tsrTopMain.Text = "toolStrip1";
            // 
            // tsrBtnBookInfo
            // 
            this.tsrBtnBookInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsrBtnBookInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsrBtnBookInfo.Image")));
            this.tsrBtnBookInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrBtnBookInfo.Name = "tsrBtnBookInfo";
            this.tsrBtnBookInfo.Size = new System.Drawing.Size(84, 64);
            this.tsrBtnBookInfo.Text = "toolStripButton1";
            this.tsrBtnBookInfo.Click += new System.EventHandler(this.tsrBtnBookInfo_Click);
            // 
            // tsrReaderInfo
            // 
            this.tsrReaderInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsrReaderInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsrReaderInfo.Image")));
            this.tsrReaderInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrReaderInfo.Name = "tsrReaderInfo";
            this.tsrReaderInfo.Size = new System.Drawing.Size(84, 64);
            this.tsrReaderInfo.Text = "toolStripButton2";
            this.tsrReaderInfo.Click += new System.EventHandler(this.tsrReaderInfo_Click);
            // 
            // tsrBtnBorrowAnnalInfo
            // 
            this.tsrBtnBorrowAnnalInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsrBtnBorrowAnnalInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsrBtnBorrowAnnalInfo.Image")));
            this.tsrBtnBorrowAnnalInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrBtnBorrowAnnalInfo.Name = "tsrBtnBorrowAnnalInfo";
            this.tsrBtnBorrowAnnalInfo.Size = new System.Drawing.Size(84, 64);
            this.tsrBtnBorrowAnnalInfo.Text = "toolStripButton3";
            this.tsrBtnBorrowAnnalInfo.Click += new System.EventHandler(this.tsrBtnBorrowAnnalInfo_Click);
            // 
            // tsrBtnBorrowReturnInfo
            // 
            this.tsrBtnBorrowReturnInfo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsrBtnBorrowReturnInfo.Image = ((System.Drawing.Image)(resources.GetObject("tsrBtnBorrowReturnInfo.Image")));
            this.tsrBtnBorrowReturnInfo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsrBtnBorrowReturnInfo.Name = "tsrBtnBorrowReturnInfo";
            this.tsrBtnBorrowReturnInfo.Size = new System.Drawing.Size(84, 64);
            this.tsrBtnBorrowReturnInfo.Text = "toolStripButton4";
            this.tsrBtnBorrowReturnInfo.Click += new System.EventHandler(this.tsrBtnBorrowReturnInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panIndex);
            this.panel2.Controls.Add(this.stMain);
            this.panel2.Controls.Add(this.msMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(942, 617);
            this.panel2.TabIndex = 1;
            // 
            // panIndex
            // 
            this.panIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panIndex.Location = new System.Drawing.Point(0, 28);
            this.panIndex.Name = "panIndex";
            this.panIndex.Size = new System.Drawing.Size(942, 563);
            this.panIndex.TabIndex = 2;
            // 
            // stMain
            // 
            this.stMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.stMain.Location = new System.Drawing.Point(0, 591);
            this.stMain.Name = "stMain";
            this.stMain.Size = new System.Drawing.Size(942, 26);
            this.stMain.TabIndex = 1;
            this.stMain.Text = "已登录";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "已登录";
            // 
            // msMain
            // 
            this.msMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书管理ToolStripMenuItem,
            this.读者管理ToolStripMenuItem,
            this.借还记录ToolStripMenuItem,
            this.图书ToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(942, 28);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // 图书管理ToolStripMenuItem
            // 
            this.图书管理ToolStripMenuItem.Name = "图书管理ToolStripMenuItem";
            this.图书管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.图书管理ToolStripMenuItem.Text = "图书管理";
            this.图书管理ToolStripMenuItem.Click += new System.EventHandler(this.图书管理ToolStripMenuItem_Click);
            // 
            // 读者管理ToolStripMenuItem
            // 
            this.读者管理ToolStripMenuItem.Name = "读者管理ToolStripMenuItem";
            this.读者管理ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.读者管理ToolStripMenuItem.Text = "读者管理";
            this.读者管理ToolStripMenuItem.Click += new System.EventHandler(this.读者管理ToolStripMenuItem_Click);
            // 
            // 借还记录ToolStripMenuItem
            // 
            this.借还记录ToolStripMenuItem.Name = "借还记录ToolStripMenuItem";
            this.借还记录ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.借还记录ToolStripMenuItem.Text = "借还记录";
            this.借还记录ToolStripMenuItem.Click += new System.EventHandler(this.借还记录ToolStripMenuItem_Click);
            // 
            // 图书ToolStripMenuItem
            // 
            this.图书ToolStripMenuItem.Name = "图书ToolStripMenuItem";
            this.图书ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.图书ToolStripMenuItem.Text = "图书借还";
            this.图书ToolStripMenuItem.Click += new System.EventHandler(this.图书ToolStripMenuItem_Click);
            // 
            // BookMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 698);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.msMain;
            this.Name = "BookMainForm";
            this.Text = "图书管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.BookMainForm_FormClosing);
            this.Load += new System.EventHandler(this.BookMainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsrTopMain.ResumeLayout(false);
            this.tsrTopMain.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.stMain.ResumeLayout(false);
            this.stMain.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem 图书管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 读者管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借还记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书ToolStripMenuItem;
        private System.Windows.Forms.Panel panIndex;
        private System.Windows.Forms.StatusStrip stMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip tsrTopMain;
        private System.Windows.Forms.ToolStripButton tsrBtnBookInfo;
        private System.Windows.Forms.ToolStripButton tsrReaderInfo;
        private System.Windows.Forms.ToolStripButton tsrBtnBorrowAnnalInfo;
        private System.Windows.Forms.ToolStripButton tsrBtnBorrowReturnInfo;
    }
}