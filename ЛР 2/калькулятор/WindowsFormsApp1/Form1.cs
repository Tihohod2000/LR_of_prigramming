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
        public string D;
        public string N1;
        public bool n2;
        public double memory;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text=="0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1=textBox1.Text;
            n2 = true;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);
            if (D == "+")
            {
                res = dn1 + dn2;
            }
            if (D == "-")
            {
                res = dn1 - dn2;
            }
            if (D == "*")
            {
                res = dn1 * dn2;
            }
            if (D == "/")
            {
                res = dn1 / dn2;
            }
            if (D == "%")
            {
                res = dn2 * (dn1 / 100);
            }
            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text=res.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1/dn;
            textBox1.Text = res.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length-1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }


        private void простойКалькуляторToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(335, 435);
        }

        private void sinxToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Size = new Size(648, 434);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            double dn1, res;
            dn1 = 0;
            res = 1;

            var txt = textBox2.Text;

            bool isNumber = int.TryParse(txt, out int numericValue);

            errorProvider1.Clear();

            if (isNumber == true)
            {
                
                dn1 = Convert.ToDouble(textBox2.Text);
            

            //isNumber is true

            

                if (textBox2.Text != "0")
                {
                    while (dn1 >= 1)
                    {
                        res = res * dn1;
                        dn1--;

                    }
                    textBox2.Text = res.ToString();
                }
                if (textBox2.Text == "0")
                {
                    textBox2.Text = "1";
                }
            }
            else if (isNumber == false)
            {
                errorProvider1.SetError(textBox2, "Не верно введены данные");
            }
           
         }

        private void button29_Click(object sender, EventArgs e)
        {
            double dn1, res;
            res = 1;
            dn1 = 0;
            var txt = textBox3.Text;

            bool isNumber = int.TryParse(txt, out int numericValue);
            errorProvider1.Clear();

            if (isNumber == true)
            {
                dn1 = Convert.ToDouble(textBox3.Text);
                res = Math.Sin(dn1);
                textBox3.Text = res.ToString();

            }
            else if (isNumber == false)
            {
                errorProvider1.SetError(textBox3, "Не верно введены данные");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            memory = Convert.ToDouble(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = memory.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            memory += Convert.ToDouble(textBox1.Text);
            textBox1.Text = memory.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            memory -= Convert.ToDouble(textBox1.Text);
            textBox1.Text = memory.ToString();
        }
    }
}
