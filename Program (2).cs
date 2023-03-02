using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter N : ");
            int N = int.Parse(Console.ReadLine());
            Console.Write("Enter x : ");
            int x = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = x; i < N; i++)
            {
                int j = i;
                while (j != 0)
                {
                    if (j % 10 == x)
                    {
                        Console.Write(" " + i);
                        count++;
                    }
                    j /= 10;
                }
            }
            Console.WriteLine("\nCount : "+count);
        }
    }
}
