using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    class Person : ICommon
    {
        protected string Id { get; set; } = string.Empty;
        protected string Name { get; set; } = string.Empty;
        protected string Cnic { get; set; } = string.Empty;
        protected string Address { get; set; } = string.Empty;
        protected string Phone { get; set; } = string.Empty;
        


        public virtual void display()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("CNIC: " + Cnic);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Address: " + Address);
        }


    }
}
