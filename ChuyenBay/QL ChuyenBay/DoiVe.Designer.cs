namespace QL_ChuyenBay
{
    partial class DoiVe
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
            this.txtmave = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnkiemtra = new System.Windows.Forms.Button();
            this.btntieptuc = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dgvhanhkhach = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanhkhach)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmave
            // 
            this.txtmave.Location = new System.Drawing.Point(112, 24);
            this.txtmave.Name = "txtmave";
            this.txtmave.Size = new System.Drawing.Size(243, 26);
            this.txtmave.TabIndex = 7;
            this.txtmave.TextChanged += new System.EventHandler(this.txtmave_TextChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 23);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã vé:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtmave);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(177, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(523, 105);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kiểm tra thông tin";
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkiemtra.Location = new System.Drawing.Point(187, 134);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(92, 31);
            this.btnkiemtra.TabIndex = 9;
            this.btnkiemtra.Text = "Kiểm tra";
            this.btnkiemtra.UseVisualStyleBackColor = true;
            this.btnkiemtra.Click += new System.EventHandler(this.btnkiemtra_Click);
            // 
            // btntieptuc
            // 
            this.btntieptuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntieptuc.Location = new System.Drawing.Point(386, 134);
            this.btntieptuc.Name = "btntieptuc";
            this.btntieptuc.Size = new System.Drawing.Size(92, 31);
            this.btntieptuc.TabIndex = 9;
            this.btntieptuc.Text = "Tiếp tục";
            this.btntieptuc.UseVisualStyleBackColor = true;
            this.btntieptuc.Click += new System.EventHandler(this.btntieptuc_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(608, 134);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(92, 31);
            this.btnthoat.TabIndex = 9;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dgvhanhkhach
            // 
            this.dgvhanhkhach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanhkhach.Location = new System.Drawing.Point(83, 171);
            this.dgvhanhkhach.Name = "dgvhanhkhach";
            this.dgvhanhkhach.Size = new System.Drawing.Size(667, 183);
            this.dgvhanhkhach.TabIndex = 10;
            // 
            // DoiVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 395);
            this.Controls.Add(this.dgvhanhkhach);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btntieptuc);
            this.Controls.Add(this.btnkiemtra);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "DoiVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoiVe";
            this.Load += new System.EventHandler(this.DoiVe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanhkhach)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtmave;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnkiemtra;
        private System.Windows.Forms.Button btntieptuc;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgvhanhkhach;
    }
}