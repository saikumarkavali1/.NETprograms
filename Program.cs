using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                              Welcome to Vegetables Mart\n\nList of Vegetables : carrot,potato,tomato,onion");
            string v1 = "carrot", v2 = "potato", v3 = "tomato", v4 = "onion";
            int q;
            Console.Write("\nenter the vegetable you want : ");
            string veg = Console.ReadLine();
            if (veg == v1)
            {
                Console.WriteLine("Carrot price per 1 kg : 50rs");
                Console.Write("Enter kgs : ");
                q = Convert.ToInt32(Console.ReadLine());
                double bill = 50 * q;
                Console.WriteLine("bill amount : " + bill);
            }
            else if (veg == v2)
            {
                Console.WriteLine("Potato price per 1 kg : 40rs");
                Console.Write("Enter kgs : ");
                q = Convert.ToInt32(Console.ReadLine());
                double bill = 40 * q;
                Console.WriteLine("bill amount : " + bill);
            }
            else
            {
                if(veg==v3)
                {

                    Console.WriteLine("Tomato price per 1 kg : 30rs");
                    Console.Write("Enter kgs : ");
                    q = Convert.ToInt32(Console.ReadLine());
                    double bill = 30 * q;
                    Console.WriteLine("bill amount : " + bill);
                }
                else if(veg==v4)
                {

                    Console.WriteLine("Onion price per 1 kg : 20rs");
                    Console.Write("Enter kgs : ");
                    q = Convert.ToInt32(Console.ReadLine());
                    double bill = 20 * q;
                    Console.WriteLine("bill amount : " + bill);
                }
            } 
                
            
        }
    }
}
