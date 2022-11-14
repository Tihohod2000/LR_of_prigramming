using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Laba_3__2
{

    public partial class Form1 : Form
    {
        string[] application = { " " };
        string[] staff = { " " };
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            application = textBox1.Text.Split(' ', '\n');
            listBox1.Items.AddRange(application);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            staff = textBox2.Text.Split(' ', '\n');
            listBox2.Items.AddRange(staff);
            textBox2.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                for (int i = 0; i < application.Length; i++)//

                {
                    bool found = false;
                    for (int j = 0; j < staff.Length; j++)
                    {
                        found = false;
                        if (application[i] == staff[j])
                        {
                            string[] mas = { application[i] };
                            listBox3.Items.AddRange(mas);
                            //listBox3.Items.Add(application[i]);
                            found = true;
                            break;
                        }

                    }
                    if (!found)
                    {
                        listBox3.Items.Add("Фамилии " + application[i]+ " нет");
                        continue;
                    }
                }
            }

            catch
            {
                return;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            Array.Clear(application, 0, application.Length);
            Array.Clear(staff, 0, staff.Length);
        }
    }

}

