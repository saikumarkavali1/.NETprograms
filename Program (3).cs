using System;
using System.Linq;

namespace arrayimp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter array size : ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("Enter "+i+" number : ");
                arr[i] = int.Parse(Console.ReadLine());
            }
            int s = arr.Min();
            int[] arr1 = new int[n];
            for(int i = 0; i < arr.Length; i++)
            {
                arr1[i] = arr[i]-s;
                Console.Write(arr1[i]+" ");
            }
            
        }
    }
}
