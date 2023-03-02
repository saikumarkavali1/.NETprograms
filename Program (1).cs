using System;

namespace count_zeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (num > 0)
            {
                if (num % 10 == 0)
                    count++;
                num = num / 10;
            }
            Console.WriteLine("Number of Zero's in the given number : " + count);
        }
    }
}
