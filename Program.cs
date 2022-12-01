using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter employee ID : ");
            int eid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter employee name : ");
            string ename = Console.ReadLine();
            Console.Write("Enter gender : ");
            char g = Convert.ToChar(Console.ReadLine());
            Console.Write("Enter employee salary : ");
            double sal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEmp ID : " + eid + "\nEmp Name : " + ename + "\nEmp Gender : " + g + "\nEmp Salary : " + sal);
        }
    }
}
