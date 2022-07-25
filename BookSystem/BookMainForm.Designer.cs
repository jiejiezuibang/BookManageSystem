
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panIndex = new System.Windows.Forms.Panel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.图书管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.读者管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借还记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stMain = new System.Windows.Forms.StatusStrip();
            this.tsrTopMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.msMain.SuspendLayout();
            this.stMain.SuspendLayout();
            this.tsrTopMain.SuspendLayout();
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
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel1.Text = "已登录";
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
            // tsrTopMain
            // 
            this.tsrTopMain.ImageScalingSize = new System.Drawing.Size(80, 60);
            this.tsrTopMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4});
            this.tsrTopMain.Location = new System.Drawing.Point(0, 0);
            this.tsrTopMain.Name = "tsrTopMain";
            this.tsrTopMain.Size = new System.Drawing.Size(942, 87);
            this.tsrTopMain.TabIndex = 1;
            this.tsrTopMain.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(104, 84);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(104, 84);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(104, 84);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(104, 84);
            this.toolStripButton4.Text = "toolStripButton4";
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.stMain.ResumeLayout(false);
            this.stMain.PerformLayout();
            this.tsrTopMain.ResumeLayout(false);
            this.tsrTopMain.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
    }
}