using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SigmaLogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            Pen bluePen = new Pen(Color.Blue, 15);
            Pen blackPen = new Pen(Color.Black, 15);
            Pen redPen = new Pen(Color.Red, 15);
            Pen yellowPen = new Pen(Color.Yellow, 15);
            Pen greenPen = new Pen(Color.Green, 15);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);
            SolidBrush blackBrush = new SolidBrush(Color.Black);

            g.Clear(Color.White);

            g.DrawEllipse(bluePen, 65, 20, 200, 200);
            g.DrawEllipse(blackPen, 300, 20, 200, 200);
            g.DrawEllipse(redPen, 535, 20, 200, 200);
            g.DrawEllipse(yellowPen, 183, 130, 200, 200);
            g.DrawEllipse(greenPen, 418, 130, 200, 200);
            g.TranslateTransform(470, 385);
            g.RotateTransform(180);
            g.DrawString("Olypics 2024", drawFont, blackBrush, 0, 0);
            g.ResetTransform();
        }
    }
}
