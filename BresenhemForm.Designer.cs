namespace Graphics_Package
{
    partial class BresenhemForm
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
            this.txt_y1 = new System.Windows.Forms.TextBox();
            this.txt_y2 = new System.Windows.Forms.TextBox();
            this.txt_x2 = new System.Windows.Forms.TextBox();
            this.txt_x1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.draw_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.txt_y1);
            this.panel1.Controls.Add(this.txt_y2);
            this.panel1.Controls.Add(this.txt_x2);
            this.panel1.Controls.Add(this.txt_x1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.draw_btn);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 668);
            this.panel1.TabIndex = 0;
            // 
            // txt_y1
            // 
            this.txt_y1.Location = new System.Drawing.Point(12, 101);
            this.txt_y1.Name = "txt_y1";
            this.txt_y1.Size = new System.Drawing.Size(97, 27);
            this.txt_y1.TabIndex = 9;
            // 
            // txt_y2
            // 
            this.txt_y2.Location = new System.Drawing.Point(12, 223);
            this.txt_y2.Name = "txt_y2";
            this.txt_y2.Size = new System.Drawing.Size(97, 27);
            this.txt_y2.TabIndex = 8;
            // 
            // txt_x2
            // 
            this.txt_x2.Location = new System.Drawing.Point(12, 162);
            this.txt_x2.Name = "txt_x2";
            this.txt_x2.Size = new System.Drawing.Size(97, 27);
            this.txt_x2.TabIndex = 7;
            // 
            // txt_x1
            // 
            this.txt_x1.Location = new System.Drawing.Point(12, 40);
            this.txt_x1.Name = "txt_x1";
            this.txt_x1.Size = new System.Drawing.Size(97, 27);
            this.txt_x1.TabIndex = 6;
            this.txt_x1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(38, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Y2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(38, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 28);
            this.label7.TabIndex = 4;
            this.label7.Text = "X2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(38, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 28);
            this.label6.TabIndex = 3;
            this.label6.Text = "Y1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(38, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "X1";
            // 
            // draw_btn
            // 
            this.draw_btn.Location = new System.Drawing.Point(12, 592);
            this.draw_btn.Name = "draw_btn";
            this.draw_btn.Size = new System.Drawing.Size(97, 29);
            this.draw_btn.TabIndex = 1;
            this.draw_btn.Text = "Draw";
            this.draw_btn.UseVisualStyleBackColor = true;
            this.draw_btn.Click += new System.EventHandler(this.draw_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 627);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(123, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(975, 668);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // BresenhemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1098, 668);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1116, 715);
            this.MinimumSize = new System.Drawing.Size(1116, 715);
            this.Name = "BresenhemForm";
            this.Text = "BresenhemForm";
            this.Load += new System.EventHandler(this.BresenhemForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button draw_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_y1;
        private System.Windows.Forms.TextBox txt_y2;
        private System.Windows.Forms.TextBox txt_x2;
        private System.Windows.Forms.TextBox txt_x1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}