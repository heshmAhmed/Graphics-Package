namespace Graphics_Package
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bre_btn = new System.Windows.Forms.Button();
            this.dda_btn = new System.Windows.Forms.Button();
            this.ellipse_btn = new System.Windows.Forms.Button();
            this.circle_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bre_btn
            // 
            this.bre_btn.Location = new System.Drawing.Point(30, 194);
            this.bre_btn.Name = "bre_btn";
            this.bre_btn.Size = new System.Drawing.Size(233, 42);
            this.bre_btn.TabIndex = 0;
            this.bre_btn.Text = "A line with Bresenhem";
            this.bre_btn.UseVisualStyleBackColor = true;
            this.bre_btn.Click += new System.EventHandler(this.bre_btn_Click);
            // 
            // dda_btn
            // 
            this.dda_btn.Location = new System.Drawing.Point(30, 135);
            this.dda_btn.Name = "dda_btn";
            this.dda_btn.Size = new System.Drawing.Size(233, 42);
            this.dda_btn.TabIndex = 1;
            this.dda_btn.Text = "A line with DDA";
            this.dda_btn.UseVisualStyleBackColor = true;
            this.dda_btn.Click += new System.EventHandler(this.dda_btn_Click);
            // 
            // ellipse_btn
            // 
            this.ellipse_btn.Location = new System.Drawing.Point(327, 194);
            this.ellipse_btn.Name = "ellipse_btn";
            this.ellipse_btn.Size = new System.Drawing.Size(233, 42);
            this.ellipse_btn.TabIndex = 2;
            this.ellipse_btn.Text = "An Ellipse";
            this.ellipse_btn.UseVisualStyleBackColor = true;
            this.ellipse_btn.Click += new System.EventHandler(this.ellipse_btn_Click);
            // 
            // circle_btn
            // 
            this.circle_btn.Location = new System.Drawing.Point(327, 135);
            this.circle_btn.Name = "circle_btn";
            this.circle_btn.Size = new System.Drawing.Size(233, 42);
            this.circle_btn.TabIndex = 3;
            this.circle_btn.Text = "A Circle";
            this.circle_btn.UseVisualStyleBackColor = true;
            this.circle_btn.Click += new System.EventHandler(this.circle_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(204, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 81);
            this.label1.TabIndex = 4;
            this.label1.Text = "Draw";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 270);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.circle_btn);
            this.Controls.Add(this.ellipse_btn);
            this.Controls.Add(this.dda_btn);
            this.Controls.Add(this.bre_btn);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bre_btn;
        private System.Windows.Forms.Button dda_btn;
        private System.Windows.Forms.Button ellipse_btn;
        private System.Windows.Forms.Button circle_btn;
        private System.Windows.Forms.Label label1;
    }
}

