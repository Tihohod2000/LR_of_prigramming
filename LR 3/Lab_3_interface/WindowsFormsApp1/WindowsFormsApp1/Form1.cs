using System;
using System.Globalization;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        int tip = 0;
        int agree;
        string name;
        string mark;
        string number;
        string year;
        string[] mas = new string[20];
        int count = 0;
        string alf = "йфяцычувскамепинртгоьшлбщдюзхъёЙФЯЦЫЧУВСКАМЕПИНРТГОЬШЛБЩДЮЗЖХЭЪЁ- ";
        string alf2 = "123456789";
        bool correct = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
            {
                if (tip == 0)
                {
                    listBox1.Items.Add("ФИ | марка | номер | год выпуска");
                    tip = 1;
                }
                return;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agree = 0;


            //Имя влядельца автомобиля
            correct = false;
            name = textBox1.Text;

            //Преобразование Прервых букв ФИо
            TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
            name = ti.ToTitleCase(name);
            string[] name2;
            name2 = name.Split(' ');
            if (name2.Length != 2)
            {
                //Console.WriteLine("Не верно введина информация!");
                errorProvider1.SetError(textBox1, "Ошибка! Данный указанный не верно!");
                agree = 0;

            }
            else
            {

                for (int i = 0; i < name.Length; i++)
                {

                    for (int j = 0; j < alf.Length; j++)
                    {
                        if (name[i] == alf[j])
                        {
                            correct = true;
                            break;
                        }
                        else
                        {
                            correct = false;
                        }
                    }
                    if (!correct)
                    {
                        errorProvider1.SetError(textBox1, "Ошибка! Данный указанный не верно!");
                        agree = 0;
                        break;
                    }
                }

                if (correct)
                {
                    errorProvider1.Clear();
                    agree++;
                }
            }


            //Номер автомобиля
            correct = false;
            number = textBox4.Text;
            if (number.Length != 8)
            {
                errorProvider2.SetError(textBox4, "Ошибка! Данный указанный не верно!");
                agree = 0;
                goto ERROR1;
            }
            for (int i = 0; i < number.Length; i++)
            {
                if (i == 0 || i > 3 && i < 6)
                {
                    for (int j = 0; j < alf.Length; j++)
                    {
                        if (number[i] == alf[j])
                        {
                            correct = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (!correct)
                    {
                        errorProvider2.SetError(textBox4, "Ошибка! Данный указанный не верно!");
                        agree = 0;
                        break;
                    }
                }
                if (i > 0 && i < 4 || i > 5)
                {
                    correct = false;
                    for (int j = 0; j < alf2.Length; j++)
                    {
                        if (number[i] == alf2[j])
                        {
                            correct = true;
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    if (!correct)
                    {
                        errorProvider2.SetError(textBox4, "Ошибка! Данный указанный не верно!");
                        agree = 0;
                        break;
                    }
                }
            }
        ERROR1:;
            if (correct)
            {
                errorProvider2.Clear();
                agree++;
                //break;
            }


            //Год выпуска автомобиля
            year = textBox3.Text;
            if (year.Length != 4)
            {
                errorProvider3.SetError(textBox3, "Ошибка! Данный указанный не верно!");
                agree = 0;
                //continue;
            }
            else
            {
                errorProvider3.Clear();
                agree++;
                //break;
            }


            //Марка автомобиля
            mark = textBox2.Text;
            if (mark.Length < 1)
            {
                errorProvider4.SetError(textBox2, "Ошибка! Данный указанный не верно!");
                agree = 0;
            }
            else
            {
                agree++;
                errorProvider4.Clear();
            }

            //Добавление в массив
            if (agree == 4)
            {
                if (tip == 0)
                {
                    listBox1.Items.Add("ФИ | марка | номер | год выпуска");
                    tip = 1;
                }

                //Конпановка строки
                string[] car = { name, " | ", mark, " | ", number, " | ", year + "г." };
                var str = string.Join(" ", car);
                //Помещения информации об value в общей массив
                mas[count] = str;
                count++;
                agree = 0;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }


        }


        //Вывод информации в listBox
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            tip = 0;
            if (tip == 0)
            {
                listBox1.Items.Add("ФИ | марка | номер | год выпуска");
                tip = 1;
            }

            for (int i = 0; i < count; i++)
            {
                var str = string.Join(" ", mas[i]);
                listBox1.Items.Add(i + 1 + ") " + str);
            }

        }


        //Удаление всей информации
        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("ФИ | марка | номер | год выпуска");
            tip = 1;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

       
    }
}
