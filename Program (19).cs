using System;

namespace tiffin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MEE HOTEL");
            Console.WriteLine("1.Idly\n2.Dosa\n3.Vada\n4.Puri\n");
            Console.Write("Enter your choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());
            if(ch>=1 && ch<=4)
            {
                double cost = 0;
                if(ch==1)
                {
                    cost = 40;
                }
                else if(ch==2)
                {
                    cost = 60;
                }
                else if(ch==3)
                {
                    cost = 30;
                }
                else
                {
                    cost = 40;
                }
                Console.WriteLine("Cost is : " + cost);
                Console.Write("Enter Quantity : ");
                int q = Convert.ToInt32(Console.ReadLine());
                double bill = cost * q;
                Console.WriteLine("Bill Amount : " + bill);
            }
            else
            {
                Console.WriteLine("Invalid choice....");
            }
        }
    }
}
