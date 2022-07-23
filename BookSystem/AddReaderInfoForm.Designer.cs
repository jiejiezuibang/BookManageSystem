
namespace BookSystem
{
    partial class AddReaderInfoForm
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
            this.btnAddReader = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReaderName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReaderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMobil = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddReader
            // 
            this.btnAddReader.Location = new System.Drawing.Point(198, 379);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(96, 41);
            this.btnAddReader.TabIndex = 21;
            this.btnAddReader.Text = "添加读者";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 321);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 19;
            this.label5.Text = "手机号码：";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(218, 243);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(130, 25);
            this.tbAddress.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(130, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 17;
            this.label4.Text = "读者住址：";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(218, 167);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(130, 25);
            this.tbEmail.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "读者邮件：";
            // 
            // tbReaderName
            // 
            this.tbReaderName.Location = new System.Drawing.Point(218, 98);
            this.tbReaderName.Name = "tbReaderName";
            this.tbReaderName.Size = new System.Drawing.Size(130, 25);
            this.tbReaderName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "读者名称：";
            // 
            // tbReaderID
            // 
            this.tbReaderID.Location = new System.Drawing.Point(218, 31);
            this.tbReaderID.Name = "tbReaderID";
            this.tbReaderID.Size = new System.Drawing.Size(130, 25);
            this.tbReaderID.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "读者编号：";
            // 
            // tbMobil
            // 
            this.tbMobil.Location = new System.Drawing.Point(218, 311);
            this.tbMobil.Name = "tbMobil";
            this.tbMobil.Size = new System.Drawing.Size(130, 25);
            this.tbMobil.TabIndex = 22;
            // 
            // AddReaderInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 450);
            this.Controls.Add(this.tbMobil);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbReaderName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbReaderID);
            this.Controls.Add(this.label1);
            this.Name = "AddReaderInfoForm";
            this.Text = "添加读者";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReaderName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReaderID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMobil;
    }
}