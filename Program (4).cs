using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            while (n != 0)
            {
                if ((n % 10) - (n % 100) / 10 < 0)
                {
                    count++;
                    Console.WriteLine("not accepted");
                    break;
                }
                n = n / 10;
            }
            if(count==0)
                Console.WriteLine("accepted");
        }
    }
}
