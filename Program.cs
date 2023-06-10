using System;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            // Console.WriteLine("Hello World!");
            Console.WriteLine("Введите трехзначное число");
            int num = Convert.ToInt32(Console.ReadLine());
            int num1 = num % 100 ;
            int num2 = num1 / 10 ;
            Console.WriteLine($"Вторая цифра числа = {num2}");
        }
    }
}
