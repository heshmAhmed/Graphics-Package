namespace Graphics_Package
{
    partial class EllipseForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.draw_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.yc_txt = new System.Windows.Forms.TextBox();
            this.xc_txt = new System.Windows.Forms.TextBox();
            this.ry_txt = new System.Windows.Forms.TextBox();
            this.rx_txt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picturebox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.draw_btn);
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.yc_txt);
            this.panel1.Controls.Add(this.xc_txt);
            this.panel1.Controls.Add(this.ry_txt);
            this.panel1.Controls.Add(this.rx_txt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 668);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // draw_btn
            // 
            this.draw_btn.Location = new System.Drawing.Point(12, 588);
            this.draw_btn.Name = "draw_btn";
            this.draw_btn.Size = new System.Drawing.Size(94, 29);
            this.draw_btn.TabIndex = 9;
            this.draw_btn.Text = "Draw";
            this.draw_btn.UseVisualStyleBackColor = true;
            this.draw_btn.Click += new System.EventHandler(this.draw_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(12, 623);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(94, 29);
            this.clear_btn.TabIndex = 8;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(42, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 28);
            this.label4.TabIndex = 7;
            this.label4.Text = "YC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(43, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "XC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(43, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 28);
            this.label2.TabIndex = 5;
            this.label2.Text = "RY";
            // 
            // yc_txt
            // 
            this.yc_txt.Location = new System.Drawing.Point(12, 223);
            this.yc_txt.Name = "yc_txt";
            this.yc_txt.Size = new System.Drawing.Size(97, 27);
            this.yc_txt.TabIndex = 4;
            // 
            // xc_txt
            // 
            this.xc_txt.Location = new System.Drawing.Point(12, 162);
            this.xc_txt.Name = "xc_txt";
            this.xc_txt.Size = new System.Drawing.Size(97, 27);
            this.xc_txt.TabIndex = 3;
            // 
            // ry_txt
            // 
            this.ry_txt.Location = new System.Drawing.Point(12, 101);
            this.ry_txt.Name = "ry_txt";
            this.ry_txt.Size = new System.Drawing.Size(97, 27);
            this.ry_txt.TabIndex = 2;
            // 
            // rx_txt
            // 
            this.rx_txt.Location = new System.Drawing.Point(12, 40);
            this.rx_txt.Name = "rx_txt";
            this.rx_txt.Size = new System.Drawing.Size(97, 27);
            this.rx_txt.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "RX";
            // 
            // picturebox1
            // 
            this.picturebox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.picturebox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picturebox1.Location = new System.Drawing.Point(123, 0);
            this.picturebox1.Name = "picturebox1";
            this.picturebox1.Size = new System.Drawing.Size(975, 668);
            this.picturebox1.TabIndex = 0;
            this.picturebox1.TabStop = false;
            this.picturebox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // EllipseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 668);
            this.Controls.Add(this.picturebox1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1116, 715);
            this.MinimumSize = new System.Drawing.Size(1116, 715);
            this.Name = "EllipseForm";
            this.Text = "EllipseForm";
            this.Load += new System.EventHandler(this.EllipseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox yc_txt;
        private System.Windows.Forms.TextBox xc_txt;
        private System.Windows.Forms.TextBox ry_txt;
        private System.Windows.Forms.TextBox rx_txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picturebox1;
        private System.Windows.Forms.Button draw_btn;
    }
}