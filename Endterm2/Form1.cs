using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Endterm2
{
    public partial class Form1 : Form
    {
        Graphics g;
        SolidBrush brush;
        float x = 50;
        float y = 50;
        float w = 50;
        float h = 30;
        float dx = 10;
        

        public Form1()
        {
            InitializeComponent();
            brush = new SolidBrush(Color.Blue);
            Timer t = new Timer();
            t.Tick += new EventHandler(Move);
            t.Start();
        }

        private void Move (object sender, EventArgs e)
        {
            if ((x + w) > 250)
            {
                dx = -10;
                brush = new SolidBrush(Color.Orange);
                
            }
            if (x < 20)
            {
                dx = 10;
                brush = new SolidBrush(Color.Green);
            }
            x += dx;
            Refresh();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            g = e.Graphics;
            g.DrawRectangle(new Pen(Color.Red), 10, 10, 250, 200);
            g.FillRectangle(brush, x, y, w, h);
            g.FillEllipse(new SolidBrush(Color.Black), x, y + h, w - 40, h - 10);
            g.FillEllipse(new SolidBrush(Color.Black), x+(w-10), y + h, w - 40, h - 10);
        }
    }
}
