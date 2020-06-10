using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pointx = 0;
        int pointy = 0;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics grap = panel1.CreateGraphics();
            grap.DrawEllipse(System.Drawing.Pens.Red, pointx, pointy,  2, 2);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointx = e.X;
                pointy = e.Y;
                panel1_Paint(this, null);
            }
        }
    }
}
