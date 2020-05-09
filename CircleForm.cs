using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Graphics_Package
{
    public partial class CircleForm : Form
    {
        private int pictureboxwidth;
        private int pictureboxheight;
        private Shape shape = Shape.CreateShape();
        private Bitmap bitmap;
        private string xc, yc, r;

        private void clear_btn_Click(object sender, EventArgs e)
        {
            xc_txtbx.Text = "";
            yc_txtbx.Text = "";
            r_txtbx.Text = "";
            bitmap = new Bitmap(pictureboxwidth, pictureboxheight);
            pictureBox1.Image = null;
        }

        private void CircleForm_Load(object sender, EventArgs e)
        {
            pictureboxwidth = pictureBox1.Width;
            pictureboxheight = pictureBox1.Height;
            bitmap = new Bitmap(pictureboxwidth, pictureboxheight);
        }

        private void draw_btn_Click(object sender, EventArgs e)
        {
            xc = xc_txtbx.Text;
            yc = yc_txtbx.Text;
            r  = r_txtbx.Text;
            int x_pixel, y_pixel;
            if (Validator.validate(xc, yc, r, "0"))
            {
                var pixels = shape.midPointCircleDraw(double.Parse(xc), double.Parse(yc), double.Parse(r));
                foreach(var pair in  pixels)
                {
                    x_pixel = Convert.ToInt32(pair.Item1) + (pictureboxwidth / 2);
                    y_pixel = (-1 * Convert.ToInt32(pair.Item2)) + (pictureboxheight / 2);
                    bitmap.SetPixel(x_pixel, y_pixel, Color.Black);
                }
                pictureBox1.Image = bitmap;
            }
        }

        public CircleForm()
        {
            InitializeComponent();
        }
    }
}
