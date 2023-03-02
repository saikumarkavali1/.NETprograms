using System;

namespace array1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.Write("Enter Array Length : ");
            n = int.Parse(Console.ReadLine());
            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the element A["+i+"] : ");
                A[i] = int.Parse(Console.ReadLine());
                sum = sum + A[i];
            }
            Console.WriteLine("\nSum of Array Elements : " + sum);
        }
    }
}
