using System;

namespace trash
{
    class Program
    {
        static void Main(string[] args)
        {
            long l = long.MaxValue;
            int i = (int)l;
            Console.WriteLine("i : "+i);                //-1
            byte b1, b2;
            b1 = 10;
            b2 = 20;
            int b3 = b1 + b2;
            Console.WriteLine("b3 : "+b3);              //30
            char c = 'A';
            int b = c + 1;
            Console.WriteLine("b : "+b);                //66
            char ch = 'A';
            ch++;
            Console.WriteLine("ch : "+ch);              //B
            int m = 3;
            int n = 4;
            int o = m + n / n + m;
            Console.WriteLine("o : "+0);                //0
            int p = 3;
            int q = 4;
            int r = 5;
            int s = Convert.ToInt32(p < q) + p + q - r++;
            Console.WriteLine("s : "+s);                 //3

            /*class1 c1;
            c1 = new class1();

            class1 c1 = new class1();
            */

            /* for(;;)
               Console.WriteLine("1");        //infinity 1's
            */
        }
    }
}
