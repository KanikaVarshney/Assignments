using System.Xml.Linq;

namespace Assign4
{
    internal class Emp
    {
     int Id;
     string Name;
     string reporting_manager;
     static int count;
      public  void GetCommonDetails()
        {
            Console.WriteLine("Enter Id");
            Id = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            Name = Console.ReadLine();
            Console.WriteLine("Enter name of reporting manager");
            reporting_manager = Console.ReadLine();
        }
        public void DisplayDetails()
        {
            Console.WriteLine("ID  is {0}", Id);
            Console.WriteLine("Name  is {0}", Name);
            Console.WriteLine("Reporting manager is {0}", reporting_manager);
        }
        public static int GetEmployeesCount()
        {
            return count;
        }
        public Emp()
        {
            count++;
        }
    }


    class OnContractEmployee : Emp
    {
        int duration;
        double charges;
        double payementAmount;
        DateTime contractDate;
        public void GetDetails()
        {
            Console.WriteLine("Enter Contract date");
            contractDate= Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter charges");
            charges = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Contract duration");
            duration = Int16.Parse(Console.ReadLine());
        }
        public void CalculatePayment()
        {
            payementAmount = charges * duration;
        }
        public void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Date of contract  is {0}", contractDate);
            Console.WriteLine("Charges  is {0}", charges);
            Console.WriteLine("Duration is {0}", duration);
        }
    }

    class OnPayRollEmployye : Emp
    {
        int exp;
        double basicSalary;
        DateTime joingDate;
        double hra, da, netSalary;
        public void GetDetails()
        {
            Console.WriteLine("Enter exp");
            exp = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("ENter basicSalary");
            basicSalary = double.Parse(Console.ReadLine());
            Console.WriteLine("ENter joingDate");
            joingDate = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("ENter hra");
            hra = double.Parse(Console.ReadLine());
            Console.WriteLine("ENter da");
            da = double.Parse(Console.ReadLine());
        }
        public void CalculatePayment()
        {
            netSalary = (da + hra + basicSalary);

        }

        public void DisplayDetails()
        {
            Console.WriteLine("BAsic Salary " + basicSalary);
            Console.WriteLine("da " + da);
            Console.WriteLine("hra is " + hra);
            Console.WriteLine("Total Net Salar " + netSalary);
        }
    }
}
