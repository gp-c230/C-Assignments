using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_csharp
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

        public int GetEmpNo()
        {
            return EmpNo;
        }
        public void SetEmpNo(int value)
        {
            this.EmpNo = value;
        }
        public string GetEmpName()
        {
            return EmpName;
        }
        public void SetEmpName(string value)
        {
            this.EmpName = value;
        }
        public double GetSalary()
        {
            return Salary;
        }
        public void SetSalary(double value)
        {
            this.Salary = value;
        }

        public double GetHra()
        {
            return HRA;
        }
        void SetHra(double value)
        {
            this.HRA = value;
        }
        public double GetTa()
        {
            return TA;
        }
        void SetTa(double value)
        {
            this.TA = value;
        }
        public double GetDa()
        {
            return DA;
        }

        void SetDa(double value)
        {
            this.DA = value;
        }
        public double GetGrossSalary()
        {
            return GrossSalary;
        }
        public void SetGrossSalary(double value)
        {
            this.GrossSalary = value;
        }
        public double GetPf()
        {
            return PF;
        }
        void SetPf(double value)
        {
            this.PF = value;
        }
        public double GetTds()
        {
            return TDS;
        }
        void SetTds(double value)
        {
            this.TDS = value;
        }
        public double GetNetSalary()
        {
            return NetSalary;
        }
        public void SetNetSalary(double value)
        {
            this.NetSalary = value;
        }

        public virtual void CalculateSalary(Employee employeedetails)
        {
            double hra = CalculateHra(employeedetails.GetSalary());
            double ta = CalculateTa(employeedetails.GetSalary());
            double da = CalculateDa(employeedetails.GetSalary());

            double grossSalary = employeedetails.GetSalary() + hra + ta + da;

            double pf = .1 * grossSalary;
            double tds = 0.18 * grossSalary;
            double netSalary = grossSalary - (pf + tds);

            employeedetails.SetHra(hra);
            employeedetails.SetTa(ta);
            employeedetails.SetDa(da);
            employeedetails.SetGrossSalary(grossSalary);
            employeedetails.SetPf(pf);
            employeedetails.SetTds(tds);
            employeedetails.SetNetSalary(netSalary);
        }

        double CalculateHra(double Salary)
        {
            if (Salary < 5000)
            {
                return .1 * Salary;
            }
            else if (Salary < 10000)
            {
                return .15 * Salary;
            }
            else if (Salary < 15000)
            {
                return .20 * Salary;
            }
            else if (Salary < 15000)
            {
                return .25 * Salary;
            }
            else
            {
                return .30 * Salary;
            }
        }
        double CalculateTa(double Salary)
        {
            if (Salary < 5000)
            {
                return .05 * Salary;
            }
            else if (Salary < 10000)
            {
                return .1 * Salary;
            }
            else if (Salary < 15000)
            {
                return .15 * Salary;
            }
            else if (Salary < 15000)
            {
                return .20 * Salary;
            }
            else
            {
                return .25 * Salary;
            }
        }
        double CalculateDa(double Salary)
        {
            if (Salary < 5000)
            {
                return .15 * Salary;
            }
            else if (Salary < 10000)
            {
                return .20 * Salary;
            }
            else if (Salary < 15000)
            {
                return .25 * Salary;
            }
            else if (Salary < 15000)
            {
                return .30 * Salary;
            }
            else
            {
                return .35 * Salary;
            }
        }
    }
}
