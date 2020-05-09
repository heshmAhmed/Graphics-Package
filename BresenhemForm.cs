using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Graphics_Package
{
    public partial class BresenhemForm : Form
    {
        private int pictureboxwidth;
        private int pictureboxheight;
        private Shape shape = Shape.CreateShape();
        private Bitmap bitmap;
        private string x1, y1, x2, y2;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void draw_btn_Click(object sender, EventArgs e)
        {
            x1 = txt_x1.Text;
            y1 = txt_y1.Text;
            x2 = txt_x2.Text;
            y2 = txt_y2.Text;
            int x_pixel, y_pixel;
            if (Validator.validate(x1, x2, y1, y2))
            {
                var pixels = shape.bresenham(double.Parse(x1), double.Parse(y1),
                    double.Parse(x2), double.Parse(y2));
                foreach(var pair in pixels)
                {
                    x_pixel = Convert.ToInt32(pair.Item1) + (pictureboxwidth / 2);
                    y_pixel = (-1 * Convert.ToInt32(pair.Item2)) + (pictureboxheight / 2);
                    bitmap.SetPixel(x_pixel, y_pixel, Color.Black);
                }
                pictureBox1.Image = bitmap;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txt_x1.Text = "";
            txt_y1.Text = "";
            txt_x2.Text = "";
            txt_y2.Text = "";
            bitmap = new Bitmap(pictureboxwidth, pictureboxheight);
            pictureBox1.Image = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public BresenhemForm()
        {
            InitializeComponent();
        }

        private void BresenhemForm_Load(object sender, EventArgs e)
        {
            pictureboxwidth = pictureBox1.Width;
            pictureboxheight = pictureBox1.Height;
            bitmap = new Bitmap(pictureboxwidth, pictureboxheight);
        }


    }
}
