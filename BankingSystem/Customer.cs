using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Customer : Person
    {
        private string Email = String.Empty;


        public Customer(string id, string name, string cnic, string phone, string address, string email)
        {
            Id = id;
            Name = name;
            Cnic = cnic;
            Phone = phone;
            Address = address;
            Email = email;
        }


        public override void display()
        {
            Console.WriteLine("ID: " + Id);  
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("CNIC: " + Cnic);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Email: " + Email);
        }


        // Implement setter and getter functions here

    }
}
