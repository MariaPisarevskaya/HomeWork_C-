﻿using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            // _____________дз 1 задача 2___________________________________
            // Console.WriteLine("Введите число 1");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Введите число 2,отличное от числа 1");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // if (num1 > num2)
            // {
            //     Console.WriteLine("Число 1 - большее, число 2 - меньшее");
            // }
            // else 
            // {
            //     Console.WriteLine("Число 2 - большее, число 1 - меньшее");
            // }
            // _____________дз 1 Задача 4___________________________________
            // Console.WriteLine("Введите число 1");
            // int num1 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Введите число 2");
            // int num2 = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Введите число 3");
            // int num3 = Convert.ToInt32(Console.ReadLine());
            // if (num1 > num2)
            // {
            //  if (num1 > num3)
            //  {
            //     Console.WriteLine($"Число {num1} - большее");
            //  } else 
            //     { 
            //         Console.WriteLine($"Число {num3} - большее");
            //     }
            // } else if (num2 > num3)
            // {
            //     Console.WriteLine($"Число {num2} - большее");
            // } else 
            // {
            //     Console.WriteLine($"Число {num3} - большее");
            // }
            // ____________дз 1 Задача 6___________________________________________
            // Console.WriteLine("Введите число");
            // int num = Convert.ToInt32(Console.ReadLine());
            // if (num%2 == 0)
            // {
            //     Console.WriteLine($"Число {num} является четным");
            // }
            // else Console.WriteLine($"Число {num} не является четным");
            // ________________дз 1 Задача 8____________________________________________
            Console.WriteLine("Введите число");
            int num = Convert.ToInt32(Console.ReadLine());
            int numtemp = 1 ;
            while (numtemp <= num)
            {
                if (numtemp%2 == 0) 
                {
                Console.WriteLine(numtemp);
                numtemp = numtemp + 1 ;
                } else numtemp = numtemp + 1 ;
            }
            
        }
    }
}



