﻿using System;

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
            //    Console.WriteLine("Введите цифру, обозначающую день недели");
            //    int num = Convert.ToInt32(Console.ReadLine());
            //    if (num < 6)
            //    {
            //     Console.WriteLine("нет");
            //    } else
            //    {
            //     Console.WriteLine("да");
            //    }
            // ______________________________________________________________________________________________
//             DZ 2__________________________Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве
//                Console.WriteLine("Введите Х1");
//                int X1 = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Введите Y1");
//                int Y1 = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Введите Z1");
//                int Z1 = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Введите Х2");
//                int X2 = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Введите Y2");
//                int Y2 = Convert.ToInt32(Console.ReadLine());
//                Console.WriteLine("Введите Z3");
//                int Z2 = Convert.ToInt32(Console.ReadLine());

//                double d =Math.Sqrt(Math.Pow((X2-X1),2) + Math.Pow((Y2-Y1),2) + Math.Pow((Z2-Z1),2));
//                Console.WriteLine(d);
//                ______________Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
               Console.WriteLine("Введите число");
               int num = Convert.ToInt32(Console.ReadLine());

               int count = 1;
               if (num<count)
               {
                Console.WriteLine("Введите positive число");
               }
               while (count <= num)
               {
                Console.WriteLine(Math.Pow(count,3));
                count++;
               }
        }
    }
}
