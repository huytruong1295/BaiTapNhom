﻿namespace QL_ChuyenBay
{
    partial class KiemTraVe
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cbbdiemden = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnkiemtra = new System.Windows.Forms.Button();
            this.btnbanve = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.dgvkiemtra = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkiemtra)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.cbbdiemden);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(81, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(659, 102);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(121, 26);
            this.textBox1.TabIndex = 7;
            this.textBox1.Text = "TP.HCM";
            // 
            // cbbdiemden
            // 
            this.cbbdiemden.FormattingEnabled = true;
            this.cbbdiemden.Location = new System.Drawing.Point(465, 29);
            this.cbbdiemden.Name = "cbbdiemden";
            this.cbbdiemden.Size = new System.Drawing.Size(121, 28);
            this.cbbdiemden.TabIndex = 6;
            this.cbbdiemden.SelectedIndexChanged += new System.EventHandler(this.cbbdiemden_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm đến: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm đi:";
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.BackColor = System.Drawing.SystemColors.Control;
            this.btnkiemtra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnkiemtra.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnkiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkiemtra.Location = new System.Drawing.Point(178, 133);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(100, 78);
            this.btnkiemtra.TabIndex = 1;
            this.btnkiemtra.Text = "Kiểm Tra";
            this.btnkiemtra.UseVisualStyleBackColor = false;
            this.btnkiemtra.Click += new System.EventHandler(this.btnkiemtra_Click);
            // 
            // btnbanve
            // 
            this.btnbanve.BackColor = System.Drawing.SystemColors.Control;
            this.btnbanve.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnbanve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbanve.Location = new System.Drawing.Point(353, 133);
            this.btnbanve.Name = "btnbanve";
            this.btnbanve.Size = new System.Drawing.Size(109, 78);
            this.btnbanve.TabIndex = 1;
            this.btnbanve.Text = "Bán Vé";
            this.btnbanve.UseVisualStyleBackColor = false;
            this.btnbanve.Click += new System.EventHandler(this.btnbanve_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnthoat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(534, 133);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(108, 78);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dgvkiemtra
            // 
            this.dgvkiemtra.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvkiemtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkiemtra.Location = new System.Drawing.Point(45, 228);
            this.dgvkiemtra.Name = "dgvkiemtra";
            this.dgvkiemtra.Size = new System.Drawing.Size(731, 163);
            this.dgvkiemtra.TabIndex = 2;
            this.dgvkiemtra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvkiemtra_CellContentClick);
            // 
            // KiemTraVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(820, 420);
            this.Controls.Add(this.dgvkiemtra);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnbanve);
            this.Controls.Add(this.btnkiemtra);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "KiemTraVe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KiemTraVe";
            this.Load += new System.EventHandler(this.KiemTraVe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvkiemtra)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnbanve;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgvkiemtra;
        private System.Windows.Forms.ComboBox cbbdiemden;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnkiemtra;
    }
}