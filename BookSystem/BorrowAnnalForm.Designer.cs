﻿
namespace BookSystem
{
    partial class BorrowAnnalForm
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
            this.dgvBorrowAnnalInfo = new System.Windows.Forms.DataGridView();
            this.tbReaderID = new System.Windows.Forms.TextBox();
            this.btnFindBorrowAnnal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowAnnalInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(112, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "借还记录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvBorrowAnnalInfo
            // 
            this.dgvBorrowAnnalInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowAnnalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowAnnalInfo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBorrowAnnalInfo.Location = new System.Drawing.Point(0, 109);
            this.dgvBorrowAnnalInfo.Name = "dgvBorrowAnnalInfo";
            this.dgvBorrowAnnalInfo.RowHeadersWidth = 51;
            this.dgvBorrowAnnalInfo.RowTemplate.Height = 27;
            this.dgvBorrowAnnalInfo.Size = new System.Drawing.Size(942, 454);
            this.dgvBorrowAnnalInfo.TabIndex = 3;
            // 
            // tbReaderID
            // 
            this.tbReaderID.Location = new System.Drawing.Point(354, 46);
            this.tbReaderID.Name = "tbReaderID";
            this.tbReaderID.Size = new System.Drawing.Size(118, 25);
            this.tbReaderID.TabIndex = 4;
            // 
            // btnFindBorrowAnnal
            // 
            this.btnFindBorrowAnnal.Location = new System.Drawing.Point(495, 42);
            this.btnFindBorrowAnnal.Name = "btnFindBorrowAnnal";
            this.btnFindBorrowAnnal.Size = new System.Drawing.Size(75, 35);
            this.btnFindBorrowAnnal.TabIndex = 5;
            this.btnFindBorrowAnnal.Text = "查询";
            this.btnFindBorrowAnnal.UseVisualStyleBackColor = true;
            this.btnFindBorrowAnnal.Click += new System.EventHandler(this.btnFindBorrowAnnal_Click);
            // 
            // BorrowAnnalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 563);
            this.Controls.Add(this.btnFindBorrowAnnal);
            this.Controls.Add(this.tbReaderID);
            this.Controls.Add(this.dgvBorrowAnnalInfo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BorrowAnnalForm";
            this.Text = "BorrowAnnalForm";
            this.Load += new System.EventHandler(this.BorrowAnnalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowAnnalInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBorrowAnnalInfo;
        private System.Windows.Forms.TextBox tbReaderID;
        private System.Windows.Forms.Button btnFindBorrowAnnal;
    }
}