
namespace BookSystem
{
    partial class BookBorrowForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbReaderID = new System.Windows.Forms.TextBox();
            this.btnFindRederInfo = new System.Windows.Forms.Button();
            this.FindBookInfo = new System.Windows.Forms.Button();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbReaderID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbReaderName = new System.Windows.Forms.Label();
            this.dgvBookInfo = new System.Windows.Forms.DataGridView();
            this.dgvBookBorrowInfo = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookBorrowInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入读者ID";
            // 
            // tbReaderID
            // 
            this.tbReaderID.Location = new System.Drawing.Point(417, 18);
            this.tbReaderID.Name = "tbReaderID";
            this.tbReaderID.Size = new System.Drawing.Size(128, 25);
            this.tbReaderID.TabIndex = 1;
            // 
            // btnFindRederInfo
            // 
            this.btnFindRederInfo.Location = new System.Drawing.Point(577, 12);
            this.btnFindRederInfo.Name = "btnFindRederInfo";
            this.btnFindRederInfo.Size = new System.Drawing.Size(75, 31);
            this.btnFindRederInfo.TabIndex = 2;
            this.btnFindRederInfo.Text = "确定";
            this.btnFindRederInfo.UseVisualStyleBackColor = true;
            this.btnFindRederInfo.Click += new System.EventHandler(this.btnFindRederInfo_Click);
            // 
            // FindBookInfo
            // 
            this.FindBookInfo.Location = new System.Drawing.Point(361, 96);
            this.FindBookInfo.Name = "FindBookInfo";
            this.FindBookInfo.Size = new System.Drawing.Size(75, 35);
            this.FindBookInfo.TabIndex = 5;
            this.FindBookInfo.Text = "确定";
            this.FindBookInfo.UseVisualStyleBackColor = true;
            this.FindBookInfo.Click += new System.EventHandler(this.FindBookInfo_Click);
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(210, 103);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(128, 25);
            this.tbBookID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "请输入图书ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(307, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "读者ID：";
            // 
            // lbReaderID
            // 
            this.lbReaderID.AutoSize = true;
            this.lbReaderID.Location = new System.Drawing.Point(381, 60);
            this.lbReaderID.Name = "lbReaderID";
            this.lbReaderID.Size = new System.Drawing.Size(0, 15);
            this.lbReaderID.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(490, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "读者姓名：";
            // 
            // lbReaderName
            // 
            this.lbReaderName.AutoSize = true;
            this.lbReaderName.Location = new System.Drawing.Point(579, 59);
            this.lbReaderName.Name = "lbReaderName";
            this.lbReaderName.Size = new System.Drawing.Size(0, 15);
            this.lbReaderName.TabIndex = 9;
            // 
            // dgvBookInfo
            // 
            this.dgvBookInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookInfo.Location = new System.Drawing.Point(100, 154);
            this.dgvBookInfo.Name = "dgvBookInfo";
            this.dgvBookInfo.RowHeadersWidth = 51;
            this.dgvBookInfo.RowTemplate.Height = 27;
            this.dgvBookInfo.Size = new System.Drawing.Size(748, 144);
            this.dgvBookInfo.TabIndex = 10;
            // 
            // dgvBookBorrowInfo
            // 
            this.dgvBookBorrowInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookBorrowInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookBorrowInfo.Location = new System.Drawing.Point(100, 362);
            this.dgvBookBorrowInfo.Name = "dgvBookBorrowInfo";
            this.dgvBookBorrowInfo.RowHeadersWidth = 51;
            this.dgvBookBorrowInfo.RowTemplate.Height = 27;
            this.dgvBookBorrowInfo.Size = new System.Drawing.Size(748, 144);
            this.dgvBookBorrowInfo.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(758, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 32);
            this.button3.TabIndex = 12;
            this.button3.Text = "确认借书";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(758, 519);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(90, 32);
            this.btnReturnBook.TabIndex = 13;
            this.btnReturnBook.Text = "确认还书";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // BookBorrowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 563);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dgvBookBorrowInfo);
            this.Controls.Add(this.dgvBookInfo);
            this.Controls.Add(this.lbReaderName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbReaderID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FindBookInfo);
            this.Controls.Add(this.tbBookID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnFindRederInfo);
            this.Controls.Add(this.tbReaderID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BookBorrowForm";
            this.Text = "BookBorrowForm";
            this.Load += new System.EventHandler(this.BookBorrowForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookBorrowInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbReaderID;
        private System.Windows.Forms.Button btnFindRederInfo;
        private System.Windows.Forms.Button FindBookInfo;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbReaderID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbReaderName;
        private System.Windows.Forms.DataGridView dgvBookInfo;
        private System.Windows.Forms.DataGridView dgvBookBorrowInfo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReturnBook;
    }
}