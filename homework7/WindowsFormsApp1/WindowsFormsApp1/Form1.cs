using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        double th1 = 30 * Math.PI / 180;
        double th2 = 20 * Math.PI / 180;
        double per1 = 0.7;
        //double per2 = 0.7;
        double k = 1.0;

        public Form1()
        {
            InitializeComponent();
        }

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawLine(x0, y0, x1, y1);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th - th2);
            drawCayleyTree(n - 1, x1, y1, per1*k * leng, th + th1);
            
        }

        void drawLine(double x0,double y0,double x1,double y1)
        {
            Pen pen = new Pen(Color.FromName(listBox1.SelectedItem.ToString()));
            graphics.DrawLine(pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g1 = this.CreateGraphics();
            g1.Clear(BackColor);
            g1.Dispose();

            

            if (textBox1.Text!=null)
            double.TryParse(textBox1.Text,out k);
            if (graphics == null) graphics = this.CreateGraphics();

            double x0 = 200, y0 = 310,leng=50;
            double x1 = x0 + leng * Math.Cos(-Math.PI / 2-th2); double y1 = y0 + leng * Math.Sin(-Math.PI/2-th2);
            double x2 = x0 + leng*k * Math.Cos(-Math.PI / 2+th1); double y2 = y0 + leng*k * Math.Sin(-Math.PI/2+th1);
            drawLine(x0, y0,x1,y1);
            drawLine(x0, y0, x2, y2);

            drawCayleyTree(8, x1, y1, leng, -Math.PI / 2-th2);
            drawCayleyTree(8, x2, y2, leng*k, -Math.PI / 2 + th1);
        }

        
    }
}
