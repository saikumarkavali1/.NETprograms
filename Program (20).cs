using System;

namespace grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter subject-1 marks : ");
            int s1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter subject-2 marks : ");
            int s2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter subject-3 marks : ");
            int s3 = Convert.ToInt32(Console.ReadLine());
            if(s1>=35&&s2>=35&&s3>=35)
            {
                Console.WriteLine("PASS");
                int total = s1 + s2 + s3;
                double avg = (double)total / 3;
                if(avg>=75)
                {
                    Console.WriteLine("Grade-A");
                }
                else if(avg>=55 && avg<75)
                {
                    Console.WriteLine("Grade-B");
                }
                else
                {
                    Console.WriteLine("Grade-c");
                }
            }
            else
            {
                Console.WriteLine("FAIL");
            }
        }
    }
}
