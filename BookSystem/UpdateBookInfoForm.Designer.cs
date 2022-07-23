
namespace BookSystem
{
    partial class UpdateBookInfoForm
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
            this.cbBookType = new System.Windows.Forms.ComboBox();
            this.btnUpdateBookInfo = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbBookType
            // 
            this.cbBookType.FormattingEnabled = true;
            this.cbBookType.Location = new System.Drawing.Point(219, 310);
            this.cbBookType.Name = "cbBookType";
            this.cbBookType.Size = new System.Drawing.Size(129, 23);
            this.cbBookType.TabIndex = 45;
            // 
            // btnUpdateBookInfo
            // 
            this.btnUpdateBookInfo.Location = new System.Drawing.Point(190, 380);
            this.btnUpdateBookInfo.Name = "btnUpdateBookInfo";
            this.btnUpdateBookInfo.Size = new System.Drawing.Size(96, 41);
            this.btnUpdateBookInfo.TabIndex = 44;
            this.btnUpdateBookInfo.Text = "修改图书";
            this.btnUpdateBookInfo.UseVisualStyleBackColor = true;
            this.btnUpdateBookInfo.Click += new System.EventHandler(this.btnUpdateBookInfo_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 43;
            this.label5.Text = "图书类别：";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(218, 241);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(130, 25);
            this.tbPrice.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 41;
            this.label4.Text = "图书价格：";
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(218, 165);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(130, 25);
            this.tbAuthor.TabIndex = 40;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "图书作者：";
            // 
            // tbBookName
            // 
            this.tbBookName.Location = new System.Drawing.Point(218, 96);
            this.tbBookName.Name = "tbBookName";
            this.tbBookName.Size = new System.Drawing.Size(130, 25);
            this.tbBookName.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 37;
            this.label2.Text = "图书名称：";
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(218, 29);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.ReadOnly = true;
            this.tbBookID.Size = new System.Drawing.Size(130, 25);
            this.tbBookID.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 35;
            this.label1.Text = "图书编号：";
            // 
            // UpdateBookInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.cbBookType);
            this.Controls.Add(this.btnUpdateBookInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbBookName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbBookID);
            this.Controls.Add(this.label1);
            this.Name = "UpdateBookInfoForm";
            this.Text = "修改图书";
            this.Load += new System.EventHandler(this.UpdateBookInfoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbBookType;
        private System.Windows.Forms.Button btnUpdateBookInfo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.Label label1;
    }
}