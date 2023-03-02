using System;

namespace rbatch3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            int a = 0;
            if(n1>=n2)
            {
                n1 = (n1 + n2) - (n2 = n1);
            }
            
                for (int i = 1; i <= n2; i++)
                {
                    
                    a = a + n1;
                }
                Console.WriteLine(a);
            
        }
    }
}

