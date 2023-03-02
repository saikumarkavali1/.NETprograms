using System;

namespace factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter the number :");
            int n = Convert.ToInt32(Console.ReadLine());
            long f = 1;
            int i = n;
            
                while(n!=1)
                {
                f = f * n;
                n=n-1;
                }
            Console.WriteLine("factorial of " + i + " is : " + f);
            
        }
    }
}
