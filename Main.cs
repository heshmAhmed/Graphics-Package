using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Package
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void dda_btn_Click(object sender, EventArgs e)
        {
            new DDAForm().ShowDialog();
        }

        private void circle_btn_Click(object sender, EventArgs e)
        {
            new CircleForm().ShowDialog();
        }

        private void bre_btn_Click(object sender, EventArgs e)
        {
            new BresenhemForm().ShowDialog();
        }

        private void ellipse_btn_Click(object sender, EventArgs e)
        {
            new EllipseForm().ShowDialog();
        }
    }
}
