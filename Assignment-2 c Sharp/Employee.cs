using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_csharp
{
    internal class Employee
    {
        private int EmpNo;
        private string EmpName;
        private double Salary;
        private double HRA;
        private double TA;
        private double DA;
        private double PF;
        private double TDS;
        private double NetSalary;
        private double GrossSalary;

        public void setDetails(int EmpNo, string EmpName, double Salary)
        {
           this.EmpNo = EmpNo;
           this.EmpName = EmpName;
           if(Salary<5000)
            {
                HRA = Salary % 10 / 100;
                TA = Salary % 5 / 100;
                DA = Salary % 50 / 100;
                GrossSalary = Salary + HRA + TA + DA;
                CalculateSalary();
            }
            else if( Salary < 10000 )
            {
                HRA = Salary % 15 / 100;
                TA= Salary % 10 / 100;
                DA= Salary % 20 / 100;
                GrossSalary= Salary + HRA + TA + DA;
                CalculateSalary();
            }
            else if (Salary < 15000)
            {
                HRA = Salary % 20 / 100;
                TA = Salary % 15 / 100;
                DA = Salary % 25 / 100;
                GrossSalary = Salary + HRA + TA + DA;
                CalculateSalary();
            }
            else if (Salary < 20000)
            {
                HRA = Salary % 25 / 100;
                TA = Salary % 20 / 100;
                DA = Salary % 30 / 100;
                GrossSalary = Salary + HRA + TA + DA;
                CalculateSalary();
            }
            else if (Salary >= 20000)
            {
                HRA = Salary % 30 / 100;
                TA = Salary % 25 / 100;
                DA = Salary % 35 / 100;
                GrossSalary = Salary + HRA + TA + DA;
                CalculateSalary();
            }

            Console.WriteLine("Employee Number : " + EmpNo);
            Console.WriteLine("Employee Name : "+ EmpName);
            Console.WriteLine("Employee Salary : " + Salary);
            Console.WriteLine("HRA : " + HRA);
            Console.WriteLine("TA : "+TA);
            Console.WriteLine("DA : "+ DA);
            Console.WriteLine("PF : "+ PF);
            Console.WriteLine("TDS : " + TDS);
            Console.WriteLine("NetSalary : "+ NetSalary);
            Console.WriteLine("GrossSalary : "+ GrossSalary);

        }

        public void CalculateSalary()
        {
            PF = 10 % GrossSalary;
            TDS = 18 % GrossSalary;
            NetSalary =GrossSalary - ( PF + TDS);
        }
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.setDetails(101, "Abc", 20000);
            Console.ReadKey();
        }
    }
}
