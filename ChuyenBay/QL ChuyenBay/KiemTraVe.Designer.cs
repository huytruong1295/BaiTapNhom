namespace QL_ChuyenBay
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtdienden = new System.Windows.Forms.TextBox();
            this.txtdiemdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtdienden);
            this.groupBox1.Controls.Add(this.txtdiemdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(188, 85);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 26);
            this.dateTimePicker1.TabIndex = 4;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // txtdienden
            // 
            this.txtdienden.Location = new System.Drawing.Point(355, 32);
            this.txtdienden.Name = "txtdienden";
            this.txtdienden.Size = new System.Drawing.Size(137, 26);
            this.txtdienden.TabIndex = 3;
            // 
            // txtdiemdi
            // 
            this.txtdiemdi.Location = new System.Drawing.Point(86, 29);
            this.txtdiemdi.Name = "txtdiemdi";
            this.txtdiemdi.Size = new System.Drawing.Size(137, 26);
            this.txtdiemdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Điểm đến: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điểm đi:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnkiemtra
            // 
            this.btnkiemtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkiemtra.Location = new System.Drawing.Point(75, 149);
            this.btnkiemtra.Name = "btnkiemtra";
            this.btnkiemtra.Size = new System.Drawing.Size(96, 40);
            this.btnkiemtra.TabIndex = 1;
            this.btnkiemtra.Text = "Kiểm Tra";
            this.btnkiemtra.UseVisualStyleBackColor = true;
            // 
            // btnbanve
            // 
            this.btnbanve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbanve.Location = new System.Drawing.Point(200, 149);
            this.btnbanve.Name = "btnbanve";
            this.btnbanve.Size = new System.Drawing.Size(96, 40);
            this.btnbanve.TabIndex = 1;
            this.btnbanve.Text = "Bán Vé";
            this.btnbanve.UseVisualStyleBackColor = true;
            this.btnbanve.Click += new System.EventHandler(this.btnbanve_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(325, 149);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(96, 40);
            this.btnthoat.TabIndex = 1;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // dgvkiemtra
            // 
            this.dgvkiemtra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvkiemtra.Location = new System.Drawing.Point(12, 217);
            this.dgvkiemtra.Name = "dgvkiemtra";
            this.dgvkiemtra.Size = new System.Drawing.Size(514, 176);
            this.dgvkiemtra.TabIndex = 2;
            // 
            // KiemTraVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 405);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtdienden;
        private System.Windows.Forms.TextBox txtdiemdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnkiemtra;
        private System.Windows.Forms.Button btnbanve;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.DataGridView dgvkiemtra;
    }
}