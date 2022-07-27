
namespace BookSystem
{
    partial class BookManageForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManageForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnFindBook = new System.Windows.Forms.Button();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tvBookList = new System.Windows.Forms.TreeView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.imgtv = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddBook);
            this.panel1.Controls.Add(this.btnFindBook);
            this.panel1.Controls.Add(this.tbBookID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 114);
            this.panel1.TabIndex = 0;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(838, 37);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(104, 44);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "添加图书";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnFindBook
            // 
            this.btnFindBook.Location = new System.Drawing.Point(540, 37);
            this.btnFindBook.Name = "btnFindBook";
            this.btnFindBook.Size = new System.Drawing.Size(82, 44);
            this.btnFindBook.TabIndex = 2;
            this.btnFindBook.Text = "搜索";
            this.btnFindBook.UseVisualStyleBackColor = true;
            this.btnFindBook.Click += new System.EventHandler(this.btnFindBook_Click);
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(393, 49);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(124, 25);
            this.tbBookID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(209, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入图书编号:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tvBookList);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 491);
            this.panel2.TabIndex = 1;
            // 
            // tvBookList
            // 
            this.tvBookList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvBookList.ImageIndex = 0;
            this.tvBookList.ImageList = this.imgtv;
            this.tvBookList.Location = new System.Drawing.Point(0, 0);
            this.tvBookList.Name = "tvBookList";
            this.tvBookList.SelectedImageIndex = 0;
            this.tvBookList.Size = new System.Drawing.Size(193, 491);
            this.tvBookList.TabIndex = 0;
            this.tvBookList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvBookList_AfterSelect);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvBookInfo);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(193, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(892, 491);
            this.panel3.TabIndex = 2;
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.AllowUserToAddRows = false;
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBookInfo.Location = new System.Drawing.Point(0, 0);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.RowHeadersWidth = 51;
            this.dgvBookInfo.RowTemplate.Height = 27;
            this.dgvBookInfo.Size = new System.Drawing.Size(892, 491);
            this.dgvBookInfo.TabIndex = 0;
            this.dgvBookInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookInfo_CellContentClick);
            // 
            // imgtv
            // 
            this.imgtv.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgtv.ImageStream")));
            this.imgtv.TransparentColor = System.Drawing.Color.Transparent;
            this.imgtv.Images.SetKeyName(0, "4.png");
            this.imgtv.Images.SetKeyName(1, "3.png");
            // 
            // BookManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 605);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookManageForm";
            this.Text = "BookManageForm";
            this.Load += new System.EventHandler(this.BookManageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnFindBook;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TreeView tvBookList;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.ImageList imgtv;
    }
}