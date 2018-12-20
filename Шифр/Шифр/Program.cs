using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Шифр
{
   public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите строку: ");
                string str = Console.ReadLine();
                if (str == "")
                {
                    Console.WriteLine("Ошибка!");
                }
                else
                {
                    string[] split = str.Split(' ');
                    string[] mas = split;
                    Program p = new Program();
                    int j = 0;
                    foreach (var t in split)
                    {

                        string s = "";
                        for (int i = 0; i <= t.Length - 1; i++)
                        {
                            s = s + p.bit(t[i]);
                        }
                        mas[j] = s;
                        j++;
                    }
                    for (int i = 0; i <= mas.Length - 1; i++)
                        Console.Write(mas[i] + " ");

                }
                Console.ReadLine();
            }
            
        }
        public string bit(int t)
        {
            int a = Convert.ToChar(t) - 2;
            char ss = Convert.ToChar(a);
            return Convert.ToString(ss);
        }
    }
}
