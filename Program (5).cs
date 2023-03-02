using System;

namespace prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            for (int i = 2; i < n; i++)
            {
               if (n % i == 0)
               {
                  count++;
                  break;
               }
            }
            if (count > 0)
                Console.WriteLine(n+" is Not Prime number");
            else
                Console.WriteLine(n+" is Prime number");
        }
    }
}
