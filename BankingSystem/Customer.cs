using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Customer : Person
    {
        public Account account;

        public string Email {  get; set; }
        

        public Customer(int id, string name, string cnic, string phone, string address, string email, string accType, int accNumbr)
        {
            Id = id;
            Name = name;
            Cnic = cnic;
            Phone = phone;
            Address = address;
            Email = email;
            if (accType == "1")
            {
                account = new SavingsAccount(5000, accNumbr, 1000, 0.25);
            }
            else
            {
                account = new CurrentAccount(5000, accNumbr, 1000, 1000);
            }   
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
    }
}
