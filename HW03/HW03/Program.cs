using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ваше имя: ");
            string name = Console.ReadLine();

            Console.Write("Ваш возраст: ");
            byte age = Byte.Parse(Console.ReadLine());

            Console.Write("Дата рождения: ");
            string birthdate = Console.ReadLine();

            Console.WriteLine(new String('-', 20));
            Console.WriteLine("Проверка введеных данных...");
            Console.WriteLine($"Имя: {name}\nВозраст: {age}\nДата рождения: {birthdate}");
            Console.ReadKey();
        }
    }
}
