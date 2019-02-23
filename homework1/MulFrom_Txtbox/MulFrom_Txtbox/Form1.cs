using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MulFrom_Txtbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == ""||this.textBox2.Text=="")
            {
                MessageBox.Show("please value a and b!", "System waring", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                return;
            }

            int a  = Convert.ToInt32(this.textBox1.Text.Trim());
            int b  = Convert.ToInt32(this.textBox2.Text.Trim());

            textBox3.Text = Convert.ToString(a * b);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Console.ReadLine();
        }

       
    }
}
