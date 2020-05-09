namespace Graphics_Package
{
    partial class DDAForm
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
            this.DDA_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DDA_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 668);
            this.panel1.TabIndex = 0;
            // 
            // DDA_picture
            // 
            this.DDA_picture.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DDA_picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DDA_picture.Location = new System.Drawing.Point(123, 0);
            this.DDA_picture.Name = "DDA_picture";
            this.DDA_picture.Size = new System.Drawing.Size(975, 668);
            this.DDA_picture.TabIndex = 1;
            this.DDA_picture.TabStop = false;
            this.DDA_picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DDAForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1098, 668);
            this.Controls.Add(this.DDA_picture);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1116, 715);
            this.MinimumSize = new System.Drawing.Size(1116, 715);
            this.Name = "DDAForm";
            this.Text = "DDAForm";
            ((System.ComponentModel.ISupportInitialize)(this.DDA_picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox DDA_picture;
    }
}