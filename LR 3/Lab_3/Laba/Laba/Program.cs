using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace car
{
    class Program
    {
        static void Main(string[] args)
        {
            string? name;
            string? mark;
            string? number;
            string year;
            string[] mas = new string[20];
            string ans = "Y";
            int count = 0;
            string alf = "йфяцычувскамепинртгоьшлбщдюзхъёЙФЯЦЫЧУВСКАМЕПИНРТГОЬШЛБЩДЮЗЖХЭЪЁ- ";
            string alf2 = "123456789";
            bool correct = false;
            Console.WriteLine("Введите информацию о машине!");


            while (ans.ToUpper() == "Y")
            {
                Console.WriteLine();
                Console.Write("Введи имя и фамилию владельца автомобиля -> ");

                while (true) 
                {
                    correct = false;
                    name = Console.ReadLine();

                    //Преобразование Прервых букв ФИО
                    TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                    name = ti.ToTitleCase(name);
                    Console.WriteLine(name);
                    string[] name2;
                    name2 = name.Split(' ');
                    if (name2.Length != 2)
                    {
                        Console.WriteLine("Не верно введина информация!");
                        continue;
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
                                Console.WriteLine("Не верно введина информация!");
                                break;
                            }
                        }
                        if (correct)
                        {
                            break;
                        }
                    }
                }

                Console.Write("Введи марку автомобиля -> ");
                mark = Console.ReadLine();
                
                Console.Write("Введи номер автомобиля -> ");
                while (true)
                {
                    correct = false;
                    number = Console.ReadLine();
                    if (number.Length != 8)
                    {
                        Console.WriteLine("Ошибка, Введите номер заново!");
                        goto ERROR1;
                    }
                    for (int i = 0; i < number.Length; i++)
                    {
                        if (i==0 || i>3 && i<6)
                        {
                           for(int j = 0; j < alf.Length; j++)
                            {
                                //Console.WriteLine(alf[j]);
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
                                Console.WriteLine("Ошибка, Введите номер заново!");
                                break;
                            }
                        }
                        if(i>0 && i<4 || i > 5)
                        {
                            correct=false;
                            for (int j = 0; j < alf2.Length; j++)
                            {
                                //Console.WriteLine(alf[j]);
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
                                Console.WriteLine("Ошибка, Введите номер заново!");
                                break;
                            }
                        }
                    }
                ERROR1:;
                    if (correct)
                    {
                        break;
                    }
                }

                Console.Write("Введи год выпуска автомобиля -> ");
                while (true)
                {
                    year = Convert.ToString(Console.ReadLine());
                    if (year.Length != 4)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }
                

                //Конпановка строки
                string[] car = { name, mark, number, year };
                var str = string.Join(" ", car);
                Console.WriteLine();
                Console.Write(str);
                Console.WriteLine();
                
                //Помещения информации об value в общей массив
                mas[count] = str;
                count++;




                Console.Write("Вывести массив МАШИНЫ в консоль? [Y/N] ");
                ans = Console.ReadLine();
                if (ans.ToUpper() == "Y")
                {
                    for (int i = 0; i < count; i++)
                    {
                        var str2 = string.Join(" ", mas[i]);
                        Console.WriteLine(str2);
                    }
                }
                Console.Write("Продолжить ввод данных? [Y/N] ");
                ans = Console.ReadLine();
                if (ans.ToUpper() == "N")
                {
                    break;
                }
                else
                {
                    ans = "Y";
                }
            }

            Console.ReadKey();
        }
    }
}