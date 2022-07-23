
namespace BookSystem
{
    partial class ReaderManageForm
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
            this.dgvReader = new System.Windows.Forms.DataGridView();
            this.btnAddReader = new System.Windows.Forms.Button();
            this.btnUpdateReaderInfo = new System.Windows.Forms.Button();
            this.btnDelReaderInfo = new System.Windows.Forms.Button();
            this.tbReaderID = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(92, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "读者信息";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvReader
            // 
            this.dgvReader.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReader.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvReader.Location = new System.Drawing.Point(0, 118);
            this.dgvReader.Name = "dgvReader";
            this.dgvReader.RowHeadersWidth = 51;
            this.dgvReader.RowTemplate.Height = 27;
            this.dgvReader.Size = new System.Drawing.Size(942, 445);
            this.dgvReader.TabIndex = 2;
            // 
            // btnAddReader
            // 
            this.btnAddReader.Location = new System.Drawing.Point(283, 38);
            this.btnAddReader.Name = "btnAddReader";
            this.btnAddReader.Size = new System.Drawing.Size(86, 55);
            this.btnAddReader.TabIndex = 3;
            this.btnAddReader.Text = "添加读者";
            this.btnAddReader.UseVisualStyleBackColor = true;
            this.btnAddReader.Click += new System.EventHandler(this.btnAddReader_Click);
            // 
            // btnUpdateReaderInfo
            // 
            this.btnUpdateReaderInfo.Location = new System.Drawing.Point(424, 38);
            this.btnUpdateReaderInfo.Name = "btnUpdateReaderInfo";
            this.btnUpdateReaderInfo.Size = new System.Drawing.Size(86, 55);
            this.btnUpdateReaderInfo.TabIndex = 4;
            this.btnUpdateReaderInfo.Text = "修改读者";
            this.btnUpdateReaderInfo.UseVisualStyleBackColor = true;
            this.btnUpdateReaderInfo.Click += new System.EventHandler(this.btnUpdateReaderInfo_Click);
            // 
            // btnDelReaderInfo
            // 
            this.btnDelReaderInfo.Location = new System.Drawing.Point(555, 38);
            this.btnDelReaderInfo.Name = "btnDelReaderInfo";
            this.btnDelReaderInfo.Size = new System.Drawing.Size(86, 55);
            this.btnDelReaderInfo.TabIndex = 5;
            this.btnDelReaderInfo.Text = "删除读者";
            this.btnDelReaderInfo.UseVisualStyleBackColor = true;
            this.btnDelReaderInfo.Click += new System.EventHandler(this.btnDelReaderInfo_Click);
            // 
            // tbReaderID
            // 
            this.tbReaderID.Location = new System.Drawing.Point(680, 55);
            this.tbReaderID.Name = "tbReaderID";
            this.tbReaderID.Size = new System.Drawing.Size(114, 25);
            this.tbReaderID.TabIndex = 6;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(819, 38);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(86, 55);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // ReaderManageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 563);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tbReaderID);
            this.Controls.Add(this.btnDelReaderInfo);
            this.Controls.Add(this.btnUpdateReaderInfo);
            this.Controls.Add(this.btnAddReader);
            this.Controls.Add(this.dgvReader);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReaderManageForm";
            this.Text = "ReaderManageForm";
            this.Load += new System.EventHandler(this.ReaderManageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReader;
        private System.Windows.Forms.Button btnAddReader;
        private System.Windows.Forms.Button btnUpdateReaderInfo;
        private System.Windows.Forms.Button btnDelReaderInfo;
        private System.Windows.Forms.TextBox tbReaderID;
        private System.Windows.Forms.Button btnFind;
    }
}