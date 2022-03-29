using System;

namespace Test3
{
    class Program
    {
        static void Main(string[] args)
        {


            // 3. 1~ 20까지 수중에서 홀수 값의 합을 출력하세요

            int sum = 0;
            Console.Write("The Odd numbers are....");
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 1)
                {
                    sum += i;
                    Console.Write($", {i}");
                }
            }

            Console.WriteLine($"\nThe sum of odd numbers between 1 and 20 is.... {sum}");
        }
    }
}
