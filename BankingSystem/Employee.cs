using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Employee : Person
    {
        public string JobTitle
        {
            get { return JobTitle; }
            set { JobTitle = value; }
        }

        public int Salary
        {
            get { return Salary; }
            set { Salary = value; }
        }




        public Employee(int id, string name, string cnic, string phone, string address, string jobTitle, int salary)
        {
            Id = id;
            Name = name;
            Cnic = cnic;
            Phone = phone;
            Address = address;
            JobTitle = jobTitle;
            Salary = salary;
        }

        public override void display()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("CNIC: " + Cnic);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Job Title: " + JobTitle);
            Console.WriteLine("Salary: " + Salary);
        }
    }
}
