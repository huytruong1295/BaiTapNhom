namespace QL_ChuyenBay
{
    partial class Main
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
            this.btnbanve = new System.Windows.Forms.Button();
            this.btndoive = new System.Windows.Forms.Button();
            this.lbname = new System.Windows.Forms.Label();
            this.btnthoa = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnbanve
            // 
            this.btnbanve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnbanve.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbanve.ForeColor = System.Drawing.Color.Black;
            this.btnbanve.Location = new System.Drawing.Point(160, 108);
            this.btnbanve.Name = "btnbanve";
            this.btnbanve.Size = new System.Drawing.Size(130, 84);
            this.btnbanve.TabIndex = 0;
            this.btnbanve.Text = "Bán Vé";
            this.btnbanve.UseVisualStyleBackColor = false;
            this.btnbanve.Click += new System.EventHandler(this.btnbanve_Click);
            // 
            // btndoive
            // 
            this.btndoive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btndoive.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndoive.ForeColor = System.Drawing.Color.Black;
            this.btndoive.Location = new System.Drawing.Point(452, 108);
            this.btndoive.Name = "btndoive";
            this.btndoive.Size = new System.Drawing.Size(130, 84);
            this.btndoive.TabIndex = 0;
            this.btndoive.Text = "Đổi Vé";
            this.btndoive.UseVisualStyleBackColor = false;
            this.btndoive.Click += new System.EventHandler(this.btndoive_Click);
            // 
            // lbname
            // 
            this.lbname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lbname.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbname.ForeColor = System.Drawing.Color.Black;
            this.lbname.Location = new System.Drawing.Point(12, 13);
            this.lbname.Name = "lbname";
            this.lbname.Size = new System.Drawing.Size(743, 58);
            this.lbname.TabIndex = 1;
            this.lbname.Text = "Chương Trình Quản Lý Vé Máy Bay.";
            this.lbname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbname.Click += new System.EventHandler(this.lbname_Click);
            // 
            // btnthoa
            // 
            this.btnthoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnthoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoa.ForeColor = System.Drawing.Color.Black;
            this.btnthoa.Location = new System.Drawing.Point(226, 236);
            this.btnthoa.Name = "btnthoa";
            this.btnthoa.Size = new System.Drawing.Size(286, 44);
            this.btnthoa.TabIndex = 2;
            this.btnthoa.Text = "Thoát";
            this.btnthoa.UseVisualStyleBackColor = false;
            this.btnthoa.Click += new System.EventHandler(this.btnthoa_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(767, 303);
            this.Controls.Add(this.btnthoa);
            this.Controls.Add(this.lbname);
            this.Controls.Add(this.btndoive);
            this.Controls.Add(this.btnbanve);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbanve;
        private System.Windows.Forms.Button btndoive;
        private System.Windows.Forms.Label lbname;
        private System.Windows.Forms.Button btnthoa;
        private System.Windows.Forms.Timer timer1;
    }
}