using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW05
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = FillForm();
            
            Console.WriteLine($"Имя: {result.firstName}\nФамилия: {result.lastName}\nВозраст: {result.age}");
            Console.Write($"Питомцы: ");
            foreach (var item in result.pets)
            {
                Console.Write($"{item} ");
            }
            Console.Write($"\nЛюбимые цета: ");
            foreach (var item in result.colors)
                Console.Write($"{item} ");
            Console.ReadKey();
        }

        static (string firstName, string lastName, int age, string[] pets, string[] colors) FillForm()
        {
            Console.Write("Введите имя: ");
            string firstName = ValidateString();
            Console.Write("Введите фамилию: ");
            string lastName = ValidateString();
            Console.Write("Введите возраст: ");
            byte age = ValidateByte();
            Console.Write("Есть наличие питомца?: ");
            var pets = FillArrayAttribute();
            Console.Write("Есть любимые цвета?: ");
            var colors = FillArrayAttribute();
            return (firstName, lastName, age, pets, colors);
        }
        static string[] FillArrayAttribute()
        {
            if (CheckBooleanAnswer())
            {
                Console.Write($"Введите количество: ");
                int count = ValidateNumeric();
                string[] name = new string[count];
                Console.WriteLine("Введите имена/названия: ");
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"{i + 1}. ");
                    name[i] = ValidateString();
                }
                return name;
            }
            else
                return new string[1] { "отсутствует" };

        }
        static string ValidateString()
        {
            do
            {
                string value = Console.ReadLine();
                if (!String.IsNullOrEmpty(value))
                    return value; 
                Console.WriteLine("Введено некорректное значение!");
            } while (true);
        }

        static int ValidateNumeric()
        {
            do
            {
                Int32.TryParse(Console.ReadLine(), out int value);
                if (value > 0)
                    return value;
                Console.WriteLine("Введено некорректное значение!");
            } while (true);
        }

        static byte ValidateByte()
        {
            do
            {
                Byte.TryParse(Console.ReadLine(), out byte value);
                if (value > 0)
                    return value;
                Console.WriteLine("Введено некорректное значение!");
            } while (true);
        }

        static bool CheckBooleanAnswer()
        {
            do
            {
                string answer = Console.ReadLine();
                if (string.Equals(answer, "да", StringComparison.OrdinalIgnoreCase))
                    return true;
                if (string.Equals(answer, "нет", StringComparison.OrdinalIgnoreCase))
                    return false;
                Console.WriteLine("Введено некорректное значение!");
            } while (true);
        }

    }
}
