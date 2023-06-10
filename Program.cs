using System;

namespace dz2
{
    class Program
    {
        static void Main(string[] args)
        {
           // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
            // Console.WriteLine("Введите трехзначное число");
            // int num = Convert.ToInt32(Console.ReadLine());
            // int num1 = num % 100 ;
            // int num2 = num1 / 10 ;
            // Console.WriteLine($"Вторая цифра числа = {num2}");
        //    Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет
            //    Console.WriteLine("Введите число");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num < 100)
            //    {
            //     Console.WriteLine("В числе нет 3-й цифры");
            //    } else
            //    {
            //     while (num >= 1000)
            //        { 
            //         num = num / 10 ;
            //        }
            //        Console.WriteLine(num % 10);
            //    }             
                    // Задача 15: Напишите программу, которая принимает на вход цифру, 
                    // обозначающую день недели, и проверяет, является ли этот день выходным.
               Console.WriteLine("Введите цифру, обозначающую день недели");
               int num = Convert.ToInt32(Console.ReadLine());
               if (num < 6)
               {
                Console.WriteLine("нет");
               } else
               {
                Console.WriteLine("да");
               }
        }
    }
}
