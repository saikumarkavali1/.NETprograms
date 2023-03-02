using System;

namespace lucky_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum = sum + n % 10;
                n = n / 10;
            }
            sum = sum % 10 + sum / 10 % 10 + sum / 100 % 10;
            Console.WriteLine("Lucky Number : "+sum);
        }
    }
}