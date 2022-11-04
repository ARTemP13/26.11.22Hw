using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov26._11
{
    internal class Program
    {
        static void Str(string a)
        {
            for (int i = a.Length-1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
        }
        static void IF(object a)
        {
            string b;
            bool b2;
            if (a is string)
            {
                Console.WriteLine("Невозможная форматирования значения объекта в строковое представление");
            }
            else
            {
                b = (string) a;
                Console.WriteLine("Строковое значение: " + b);
            }
        }
        static void Main(string[] args)
        {
            

            //Console.WriteLine("Задание 1");
            //Random random = new Random();
            //Bank bank1 = new Bank();
            //Bank bank2 = new Bank();
            //Bank bank3 = new Bank();

            //bank1.Id = random.Next(420056000, 420056999);
            //bank1.Balance = 53200;
            //bank1.Type = "Сберегательный";

            //bank2.Id = random.Next(420056000, 420056999);
            //bank2.Balance = 100123;
            //bank2.Type = "Сберегательный";

            //bank3.Id = random.Next(420056000, 420056999);
            //bank3.Balance = 20167;
            //bank3.Type = "Сберегательный";

            //double summa = double.Parse(Console.ReadLine());
            //bank1.Transfer(ref bank1, summa);

            //Console.ReadLine();



            //Console.WriteLine("Задание 2");
            //Console.WriteLine("Введите любую строку: ");
            //string str1 = Console.ReadLine();
            //Str(str1);
            //Console.ReadLine();


            //Console.WriteLine("Задание 3");
            //Console.WriteLine("Введите имя файла: ");
            //string file1 = Console.ReadLine();
            //string text = "";
            //if (File.Exists(file1))
            //{
            //    using (var st = new StreamReader("proba.txt"))
            //    {
            //        while (!(st.EndOfStream))
            //        {
            //            text = st.ReadLine();
            //        }
            //    }
            //    text = text.ToUpper();
            //    using (var str = new StreamWriter("Text.txt", true))
            //    {
            //        str.WriteLine(text);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Данного файла не существует");
            //}
            //Console.ReadLine();


            //Console.WriteLine("Задание 4");
            //Console.WriteLine("Введите какой-нибудь объект: ");
            //object proba = Console.ReadLine();
            //IF(proba);
            //Console.ReadLine();


            Console.WriteLine("Задание 5");
            List<string> fileLines = File.ReadAllLines("FIOE.txt").ToList();
            foreach (var fileLine in fileLines)
            {
                var splitFileLine = fileLine.Split(new[] { " # " }, StringSplitOptions.None);

                string fio = splitFileLine[0];
                string mail = splitFileLine[1];
                using (var str1 = new StreamWriter("Mail.txt", true))
                {
                    str1.WriteLine(mail);
                }
            }
            Console.ReadLine();


            Console.WriteLine("Задание 6");
            Song song1 = new Song();
            song1.Name();
            song1.Autor();
            song1.Info();
            Song song2 = new Song();
            song2.Name();
            song2.Autor();
            song2.Info();
            Console.ReadLine();

        }
    }
    
    
}
