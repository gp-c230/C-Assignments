using Assignment_3_csharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_csharp
{
    internal class LitwareLib : Iprintable
    {
        static void Main(string[] args)
        {
            // Creating Object of Employee Class
            Employee employee = new Employee();
            Employee manager = new Manager();
            MarketingExecutive marketing = new MarketingExecutive();
            LitwareLib lib = new LitwareLib();

            // Variable Declaration
            int empNo;
            string empName;
            double empSalary;
            double kilometer;

            // Variable Initialization
            Console.WriteLine("Enter Employee Number : ");
            empNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Name : ");
            empName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary: ");
            empSalary = Convert.ToDouble(Console.ReadLine());

            // Method Calling
            employee.SetEmpNo(empNo);
            employee.SetEmpName(empName);
            employee.SetSalary(empSalary);
            employee.CalculateSalary(employee);

            // Display Output
            Console.WriteLine("\n---- Employee Details ----");
            Console.WriteLine("Emp no:" + employee.GetEmpNo());
            Console.WriteLine("Name:" + employee.GetEmpName());
            Console.WriteLine("Salary :" + employee.GetSalary());

            // Employee Gross & Net Salary
            lib.Display(employee);

            // Manager Gross & Net Salary
            Console.WriteLine("\n ---- Manager Details ------");
            manager.CalculateSalary(employee);
            lib.Display(employee);

            // Marketing Executive Gross & Net Salary
            Console.WriteLine("\n---- Manager Details ------");

            Console.WriteLine("Enter Kilometer Travel : ");
            kilometer = Convert.ToDouble(Console.ReadLine());
            marketing.SetKilometer(kilometer);

            marketing.CalculateSalary1(employee, marketing);
            lib.Display(employee);

            Console.ReadKey();
        }

        public void Display(Employee employee)
        {
            Console.WriteLine("Gross Salary :" + employee.GetGrossSalary());
            Console.WriteLine("Net Salary : " + employee.GetNetSalary());
        }
    }
}
