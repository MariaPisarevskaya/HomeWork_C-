using System;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число 2,отличное от числа 1");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Число 1 - большее, число 2 - меньшее");
            }
            else 
            {
                Console.WriteLine("Число 2 - большее, число 1 - меньшее");
            }
        }
    }
}



