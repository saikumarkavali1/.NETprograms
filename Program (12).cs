using System;

namespace rbatch6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            for(i = 1; i <= 5; i++)
            {
                sum = sum + i;
                Console.Write(" " + i);
            }
            Console.Write("\nSum of first 5 numbers : "+sum);
        }
    }
}
