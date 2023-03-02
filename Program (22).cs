using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a,b,c,d,e,f,g,h,i,j,k,l;
            Console.Write("Enter a value : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b value : ");
            b = Convert.ToInt32(Console.ReadLine());
            b = (a + b) - (a = b);
            Console.WriteLine("After Swapping\n"+"a value is : " + a +"\nb value is : " + b);
            Console.Write("\nEnter c value : ");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter d value : ");
            d = Convert.ToInt32(Console.ReadLine());
            c = c * d;
            d = c / d;
            c = c / d;
            Console.WriteLine("After Swapping\n" + "c value is : " + c + "\nd value is : " + d);
            Console.Write("\nEnter e value : ");
            e = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter f value : ");
            f = Convert.ToInt32(Console.ReadLine());
            e = e + f;
            f = e - f;
            e = e - f;
            Console.WriteLine("After Swapping\n" + "e value is : " + e + "\nf value is : " + f);
            Console.Write("\nEnter g value : ");
            g = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter h value : ");
            h = Convert.ToInt32(Console.ReadLine());
            i = g;
            g = h;
            h = i;
            Console.WriteLine("After Swapping\n" + "g value is : " + g + "\nh value is : " + h);
            Console.Write("\nEnter j value : ");
            j = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter k value : ");
            k = Convert.ToInt32(Console.ReadLine());
            l = j + k;
            j = l - j;
            k = l - j;
            Console.WriteLine("After Swapping\n" + "j value is : " + j + "\nk is value is : " + k);
        }
    }
}
