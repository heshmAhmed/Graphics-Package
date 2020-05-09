using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Graphics_Package
{
    public partial class EllipseForm : Form
    {
        private int pictureboxwidth;
        private int pictureboxheight;
        private Shape shape = Shape.CreateShape();
        private static readonly Regex regex = new Regex(@"^\d+$");
        private Bitmap bitmap;
        private string rx, ry, xc, yc;

        public EllipseForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rx_txt.Text = "";
            ry_txt.Text = "";
            xc_txt.Text = "";
            yc_txt.Text = "";
            bitmap = new Bitmap(pictureboxwidth, pictureboxheight);
            picturebox1.Image = null;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void draw_btn_Click(object sender, EventArgs e)
        {
            rx = rx_txt.Text;
            ry = ry_txt.Text;
            xc = xc_txt.Text;
            yc = yc_txt.Text;
            int x_pixel, y_pixel;

            if (Validator.validate(rx,ry,xc,yc))
            {
                List<Tuple<double, double>> pixels = shape.MidPoinEllipseAlgo(double.Parse(rx), double.Parse(ry),
                    double.Parse(xc), double.Parse(yc));
                foreach(var pair in pixels)
                {
                    x_pixel = Convert.ToInt32(pair.Item1) + (pictureboxwidth / 2);
                    y_pixel = (-1*Convert.ToInt32(pair.Item2)) + (pictureboxheight / 2);
                    bitmap.SetPixel(x_pixel, y_pixel, Color.Black);
                }
                
                picturebox1.Image = bitmap;
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void EllipseForm_Load(object sender, EventArgs e)
        {
            pictureboxwidth = picturebox1.Width;
            pictureboxheight = picturebox1.Height;
            bitmap = new Bitmap(pictureboxwidth, pictureboxheight);
        }
    }
}
