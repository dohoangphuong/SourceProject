namespace KiemTraMonHoc
{
    partial class Download
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
            this.txtpathSave = new System.Windows.Forms.TextBox();
            this.down = new System.Windows.Forms.Button();
            this.txtSoureWeb = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbComplete = new System.Windows.Forms.Label();
            this.btBrower = new System.Windows.Forms.Button();
            this.prdownload = new System.Windows.Forms.ProgressBar();
            this.txtPathWebDown = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.open = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDieuKien = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtpathSave
            // 
            this.txtpathSave.Location = new System.Drawing.Point(143, 120);
            this.txtpathSave.Multiline = true;
            this.txtpathSave.Name = "txtpathSave";
            this.txtpathSave.Size = new System.Drawing.Size(515, 31);
            this.txtpathSave.TabIndex = 13;
            this.txtpathSave.Text = "D:\\Anh Phuot\\";
            // 
            // down
            // 
            this.down.Location = new System.Drawing.Point(463, 423);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(138, 38);
            this.down.TabIndex = 12;
            this.down.Text = "DOWNLOAD IMAGE";
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // txtSoureWeb
            // 
            this.txtSoureWeb.Location = new System.Drawing.Point(143, 244);
            this.txtSoureWeb.Multiline = true;
            this.txtSoureWeb.Name = "txtSoureWeb";
            this.txtSoureWeb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSoureWeb.Size = new System.Drawing.Size(515, 173);
            this.txtSoureWeb.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-72, -60);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(416, 33);
            this.textBox1.TabIndex = 9;
            // 
            // lbComplete
            // 
            this.lbComplete.AutoSize = true;
            this.lbComplete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbComplete.ForeColor = System.Drawing.Color.Blue;
            this.lbComplete.Location = new System.Drawing.Point(50, 203);
            this.lbComplete.Name = "lbComplete";
            this.lbComplete.Size = new System.Drawing.Size(33, 19);
            this.lbComplete.TabIndex = 17;
            this.lbComplete.Text = "0%";
            // 
            // btBrower
            // 
            this.btBrower.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btBrower.Location = new System.Drawing.Point(805, -21);
            this.btBrower.Name = "btBrower";
            this.btBrower.Size = new System.Drawing.Size(33, 31);
            this.btBrower.TabIndex = 16;
            this.btBrower.Text = "...";
            this.btBrower.UseVisualStyleBackColor = true;
            // 
            // prdownload
            // 
            this.prdownload.Location = new System.Drawing.Point(143, 199);
            this.prdownload.Name = "prdownload";
            this.prdownload.Size = new System.Drawing.Size(515, 23);
            this.prdownload.TabIndex = 15;
            // 
            // txtPathWebDown
            // 
            this.txtPathWebDown.Location = new System.Drawing.Point(143, 75);
            this.txtPathWebDown.Multiline = true;
            this.txtPathWebDown.Name = "txtPathWebDown";
            this.txtPathWebDown.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPathWebDown.Size = new System.Drawing.Size(515, 31);
            this.txtPathWebDown.TabIndex = 14;
            this.txtPathWebDown.Text = "https://dkhp.uit.edu.vn/sinhvien/hocphan/dangky";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(50, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Source code web:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(50, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Path save";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(50, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Link web:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palace Script MT", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(255, 467);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 34);
            this.label5.TabIndex = 21;
            this.label5.Text = "Design: Hoang Phuong";
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(664, 120);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(65, 31);
            this.open.TabIndex = 22;
            this.open.Text = "Open";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // run
            // 
            this.run.Location = new System.Drawing.Point(181, 423);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(138, 38);
            this.run.TabIndex = 11;
            this.run.Text = "DOWNLOAD SOURCE";
            this.run.UseVisualStyleBackColor = true;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(244, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(312, 36);
            this.label6.TabIndex = 23;
            this.label6.Text = "DOWNLOAD IMAGE";
            // 
            // txtDieuKien
            // 
            this.txtDieuKien.Location = new System.Drawing.Point(143, 157);
            this.txtDieuKien.Multiline = true;
            this.txtDieuKien.Name = "txtDieuKien";
            this.txtDieuKien.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDieuKien.Size = new System.Drawing.Size(515, 31);
            this.txtDieuKien.TabIndex = 24;
            this.txtDieuKien.Text = "src=\"";
            // 
            // Download
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 510);
            this.Controls.Add(this.txtDieuKien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.open);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpathSave);
            this.Controls.Add(this.down);
            this.Controls.Add(this.run);
            this.Controls.Add(this.txtSoureWeb);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbComplete);
            this.Controls.Add(this.btBrower);
            this.Controls.Add(this.prdownload);
            this.Controls.Add(this.txtPathWebDown);
            this.Name = "Download";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpathSave;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.TextBox txtSoureWeb;
        private System.Windows.Forms.TextBox textBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbComplete;
        private System.Windows.Forms.Button btBrower;
        private System.Windows.Forms.ProgressBar prdownload;
        private System.Windows.Forms.TextBox txtPathWebDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDieuKien;
    }
}

