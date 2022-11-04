using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov26._11
{
    internal class Song
    {
        protected string name;
        protected string autor;
        protected static Song prev;
        public void Name()
        {
            Console.WriteLine("Введите название песни: ");
            name = Console.ReadLine();
            Console.WriteLine("Песня добавлена");
        }
        public void Autor()
        {
            Console.WriteLine("Введите автора: ");
            autor = Console.ReadLine();
            Console.WriteLine("Автор добавлен");
        }
        public void Prev()
        {
            Console.WriteLine("Введите связь с предыдущей песней в списке: ");
            var a = Console.ReadLine();
            prev = this;
            Console.WriteLine("Связь добавлена");
        }
        public void Info()
        {
            Console.WriteLine($"Название песни: {name}\nАвтор песни: {autor}");
        }
        
    }
}
