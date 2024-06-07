<<<<<<< HEAD
﻿namespace BankingSystem
{
    class Program {
        static void Main(string[] args)
        { 
            Console.WriteLine("Welcome to the Banking System");

            Account account = new Account(5000, 1234, 1000);
            account.display();

            account.deposit(500);
            account.withdraw(300);
            account.withdraw(1200); // throws error Amount Exceed Maximum Transaction Amount!
            account.withdraw(1000); // balance is 4200
            account.withdraw(1000); // balance is 3200
            account.withdraw(1000); // balance is 2200
            account.withdraw(1000); // balance is 1200
            account.withdraw(1000); // balance is 200
            account.withdraw(500);  // throws error insufficient funds
            account.display();
=======
﻿using BankingSystem;

namespace BakingSystem
{
    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("1", "Ali", "12345", "12345", "12345", "dkjkd", 1000);

            Customer customer = new Customer("2", "Ahmed", "12345", "12345", "12345", "hello");
            customer.display();

            Console.WriteLine("Welcome to the Banking System/n");

            employee.display();
        
        
>>>>>>> 74378e4 (added person and it's derived classes)
        }

    }
}