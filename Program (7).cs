using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        abstract class ClsEMp
        {
            public abstract void GetEmp(int eno, string ename);
        }
        class ClsDept : ClsEMp
        {
            public override void GetEmp(int eno, string ename)
            {
                Console.WriteLine(eno + " " + ename);
            }
            public void GetDept(int dno,string dname)
            {
                Console.WriteLine(dno + " " + dname);
            }
        }
        static void Main(string[] args)
        {
            ClsDept obj = new ClsDept();
            obj.GetEmp(101, "vijay");
            obj.GetDept(10, "Accounting");
            Console.Read();
        }
    }
}
