namespace Graphics_Package
{
    partial class CircleForm
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
            this.r_txtbx = new System.Windows.Forms.TextBox();
            this.yc_txtbx = new System.Windows.Forms.TextBox();
            this.xc_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.draw_btn);
            this.panel1.Controls.Add(this.clear_btn);
            this.panel1.Controls.Add(this.r_txtbx);
            this.panel1.Controls.Add(this.yc_txtbx);
            this.panel1.Controls.Add(this.xc_txtbx);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 668);
            this.panel1.TabIndex = 0;
            // 
            // draw_btn
            // 
            this.draw_btn.Location = new System.Drawing.Point(11, 592);
            this.draw_btn.Name = "draw_btn";
            this.draw_btn.Size = new System.Drawing.Size(94, 29);
            this.draw_btn.TabIndex = 7;
            this.draw_btn.Text = "Draw";
            this.draw_btn.UseVisualStyleBackColor = true;
            this.draw_btn.Click += new System.EventHandler(this.draw_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(12, 627);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(94, 29);
            this.clear_btn.TabIndex = 6;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // r_txtbx
            // 
            this.r_txtbx.Location = new System.Drawing.Point(12, 213);
            this.r_txtbx.Name = "r_txtbx";
            this.r_txtbx.Size = new System.Drawing.Size(93, 27);
            this.r_txtbx.TabIndex = 5;
            // 
            // yc_txtbx
            // 
            this.yc_txtbx.Location = new System.Drawing.Point(12, 132);
            this.yc_txtbx.Name = "yc_txtbx";
            this.yc_txtbx.Size = new System.Drawing.Size(93, 27);
            this.yc_txtbx.TabIndex = 4;
            // 
            // xc_txtbx
            // 
            this.xc_txtbx.Location = new System.Drawing.Point(12, 51);
            this.xc_txtbx.Name = "xc_txtbx";
            this.xc_txtbx.Size = new System.Drawing.Size(93, 27);
            this.xc_txtbx.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(39, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(39, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "YC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(39, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "XC";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(123, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 668);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // CircleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1116, 715);
            this.MinimumSize = new System.Drawing.Size(1116, 715);
            this.Name = "CircleForm";
            this.Text = "CircleForm";
            this.Load += new System.EventHandler(this.CircleForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button draw_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.TextBox r_txtbx;
        private System.Windows.Forms.TextBox yc_txtbx;
        private System.Windows.Forms.TextBox xc_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}