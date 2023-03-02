using System;

namespace atm
{
    class Program
    {
        static void Main(string[] args)
        {
            int t2000 = 500, t500 = 500, t100 = 500, tamt,wamt,n2000,n500,n100;

            Console.Write("Enter the User Name : ");
            string user = Console.ReadLine();
            Console.Write("Enter the Password : ");
            int pwd = Convert.ToInt32(Console.ReadLine());

            if(user=="sai" && pwd==1234)
            {
                Console.WriteLine("\nValid Crendentials\n");
                
                Console.Write("Enter the amount in multiples of 100's");
                wamt = Convert.ToInt32(Console.ReadLine());//39400
                if (wamt % 100 != 0)
                {
                    Console.WriteLine("\nInvalid Amount");
                    return;
                }
                else
                {
                    tamt = t2000 * 2000 + t500 * 500 + t100 * 100;
                    if(tamt<wamt)
                    {
                        Console.WriteLine("\nInsufficient Funds");
                        return;
                    }
                    
                }

            }
            else
            {
                Console.WriteLine("Invalid Username or Password");
            }
            
        }
    }
}
