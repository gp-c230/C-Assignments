using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_8_CSharp
{
    [AttributeUsage(                                    //this should be placed immediately before its target
    AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property,
    AllowMultiple = true)]

    public class SoftwareAttribute : System.Attribute  //Custom attribute
    {
        private String projectName;
        private String description;
        private String clientName;
        private String startDate;
        private String endDate;

        public SoftwareAttribute(String Pn, String Dn, String Cn, String Sd, String Ed)
        {
            this.projectName = Pn;
            this.description = Dn;
            this.clientName = Cn;
            this.startDate = Sd;
            this.endDate = Ed;
        }

        public String ProjectName
        {
            get { return this.projectName; }
        }
        public String Description
        {
            get { return this.description; }
        }
        public String ClientName
        {
            get { return this.clientName; }
        }
        public String StartedDate
        {
            get { return this.startDate; }
        }
        public String EndingDate
        {
            get { return this.endDate; }
        }

    }
    [SoftwareAttribute("School management", "about School", "klmno", "18 / 06 / 2010", "12/10/2011")]
    [SoftwareAttribute("Travel management", "about travel", "asdfghj", "11 / 04 / 2015", "10/02/2018")]
    class HDFCAccount
    {
        //member variables
        protected int actNumber;
        protected String customerName;
        public HDFCAccount(int actNumber, String customerName)
        {
            this.actNumber = actNumber;
            this.customerName = customerName;
        }
        [SoftwareAttribute("School management", "about School", "klmno", "18 / 06 / 2010", "12/10/2011")]

        public int AcNumber
        {
            get
            {
                return this.actNumber;
            }
        }
        public String CustomerName
        {
            get { return this.customerName; }
        }
        public void DisplayHDFCAccountDetails()
        {
            Console.WriteLine("HDFC Account number : " + actNumber);
            Console.WriteLine("HDFC Customer Name : " + customerName);
            Console.ReadKey();
        }

    }
    [SoftwareAttribute("School management", "about School", "klmno", "18 / 06 / 2010", "12/10/2011")]
    [SoftwareAttribute("Travel management", "about travel", "asdfghj", "11 / 04 / 2015", "10/02/2018")]
    public class ICICIAccount
    {
        public int iciciAcNumber;
        public String iciciCustomerName;

        public ICICIAccount(int iciciAcNumber, String iciciCustomerName)
        {
            this.iciciAcNumber = iciciAcNumber;
            this.iciciCustomerName = iciciCustomerName;
        }
        [SoftwareAttribute("Travel management", "about travel", "asdfghj", "11 / 04 / 2015", "10/02/2018")]

        public int IciciAcNumber
        {
            get { return this.iciciAcNumber; }
        }
        public String IciciCustomerName
        {
            get { return this.iciciCustomerName; }
        }
        public void DisplayICICIAccountDetails()
        {
            Console.WriteLine("ICICI Account Number :  " + iciciAcNumber);
            Console.WriteLine("ICICI Customer Name : " + iciciCustomerName);
        }
    }

    public class TestAttribute
    {
        static void Main(String[] args)
        {
            HDFCAccount hdfc = new HDFCAccount(897632455, "qwerty");
            hdfc.DisplayHDFCAccountDetails();
            Console.WriteLine("Please Press Enter to view ICICI Account Number : ");
            Console.ReadKey();
            ICICIAccount icici = new ICICIAccount(98326534, "asdfghj");
            icici.DisplayICICIAccountDetails();

            SoftwareAttribute customAttribute = new SoftwareAttribute("EMS", "it covers pf issues", "Infosys", "14/04/1995", "15/05/1999");
        }
    }
}
