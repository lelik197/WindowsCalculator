using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCalculator
{
    public partial class WindowsCalculator : Form
    {
        public string A;
        public string FirstNumber;
        public bool SecondNumber;
        public WindowsCalculator()
        {
            SecondNumber = false;
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            if(textBox1.Text == "0")
            textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text+ B.Text;
            if (SecondNumber)
            {
                SecondNumber = false;
                textBox1.Text = "0";
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void C_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Form1_Click_1(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            A = B.Text;
            FirstNumber = textBox1.Text;
            SecondNumber = true;

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double d1, d2, res;
            res = 0;
            d1 = Convert.ToDouble(FirstNumber);
            d2 = Convert.ToDouble(textBox1.Text);
            if (A == "+")
            {
                res = d1 + d2;
            }

            if (A == "-")
            {
                res = d1 - d2;
            }

            if (A == "*")
            {
                res = d1 * d2;
            }

            if (A == "/")
            {
                res = d1 / d2;
            }

            A = "=";
            SecondNumber = true;
            textBox1.Text = res.ToString();

        }
    }
}
