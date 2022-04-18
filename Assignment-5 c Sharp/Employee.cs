using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    internal class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSal { get; set; }
        public string EmpLoc { get; set; }


    }

    internal class ArrayListSample
    {
        static void Main(string[] args)
        {

            ArrayList arrayList = new ArrayList()
            {
                    new Employee{EmpId=1,EmpName="Kalpesh",EmpSal=30000,EmpLoc="Hyderabad"},
                    new Employee{EmpId=2,EmpName="Haritha",EmpSal=15000,EmpLoc="Bangalore"},
                    new Employee{EmpId=3,EmpName="Chetan",EmpSal=42000,EmpLoc="Mumbai"},
                    new Employee{EmpId=4,EmpName="Dhiraj",EmpSal=30000,EmpLoc="Chennai"},
            };
            foreach (Employee emp in arrayList)
            {
                Console.WriteLine(emp.EmpId + " " + emp.EmpName + " " + emp.EmpSal + " " + emp.EmpLoc);
            }
            Console.ReadKey();
        }
    }
}
