using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = Numbersum(23);
            Console.WriteLine(result);
            Console.WriteLine(Ortalama(2, 3, 4, 11));
            Console.WriteLine(Sum(3,4));
            Console.WriteLine(Sum1(3));
            Console.WriteLine(Cuttek(5));


        }
        // - Verilmiş ədədin rəqəmləri cəmini qaytaran metod
        static int Numbersum(int num1)
        {
            var sum = 0;
            int numson = 0;
            while (num1 > 0)
            {
                numson = num1 % 10;
                num1 = (num1 - numson) / 10;
                sum += numson;
            }
            return sum;
        }

        // -  Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod
        static double Ortalama(int nums, int num2, int num3, int num4)
        {
            var sum = nums + num2 + num3 + num4;
            var count = 4;
            return sum / count;


        }
        // - Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod
        static int Sum(int num11,int num12)
        {
            var sum = num11+ num12;
            return sum;

        }

        // - Verilmiş ədədin kvadratını qaytaran metod
        static int Sum1(int number1)
        {
            return number1 * number1;
        }
        //Verilmish edetin cut tek oldugunu qaytaran method
        static bool Cuttek(int number123)
        {
            return number123 % 2==0;
        }





    }
}