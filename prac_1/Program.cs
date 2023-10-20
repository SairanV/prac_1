using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.
namespace prac_1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            // Задание 1
            GreetUser();

            Console.WriteLine();

            Console.WriteLine("Задание 2");
            // Задание 2
            SumNumbers();
        }

        static void GreetUser()
        {
            Console.Write("Введите ваше ФИО:  ");
            string fio = Console.ReadLine();
            string greeting = "Приветствую тебя - " + fio;
            Console.WriteLine(greeting);
        }

        static void SumNumbers()
        {
            Console.Write("Введите несколько чисел через пробел:  ");
            string input = Console.ReadLine();

            string[] numberStrings = input.Split(' ');
            int sum = 0;

            for (int i = 0; i < numberStrings.Length; i++)
            {
                if (int.TryParse(numberStrings[i], out int number))
                {
                    sum += number;
                }
                else
                {
                    Console.WriteLine($"Ошибка: '{numberStrings[i]}' не является числом и будет проигнорировано.");
                }
            }

            Console.WriteLine($"Сумма введенных чисел: {sum}");
        }
    }

}