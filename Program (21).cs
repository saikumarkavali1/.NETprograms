using System;

namespace loan
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to OUR BANK");
            Console.WriteLine("1.Education Loan\n2.Gold Loan\n3.Home Loan\n4.Personal Loan\n");
            Console.Write("Enter your choice : ");
            int ch = Convert.ToInt32(Console.ReadLine());
            if (ch >= 1 && ch <= 4)
            {
                double r = 0;
                if (ch == 1)
                {
                    r = 4.6;
                }
                else if(ch==2)
                {
                    r = 6.8;
                }
                else if(ch==3)
                {
                    r = 8.2;
                }
                else if(ch==4)
                {
                    r = 12.6;
                }
                Console.WriteLine("Rate of Interest : " + r);
                Console.Write("Enter Loan Amount : ");
                double lamt = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter Time Period : ");
                int t = Convert.ToInt32(Console.ReadLine());
                double iamt = lamt * t * r/100;
                double famt = lamt + iamt;
                double emi = famt / (t * 12);
                Console.WriteLine("\nInterest Amount : " + iamt + "\nFinal Amount : " + famt + "\nEMI amount : " + emi);
                    }
            else
            {
                Console.WriteLine("Invalid choice....");
            }
        }
    }
}
