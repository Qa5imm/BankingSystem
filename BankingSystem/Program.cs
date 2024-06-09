using BankingSystem;
using System.Security.Principal;

namespace BakingSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("ABC", 0000);
            bank.display();

            bank.addNewEmployee("Ali", "12345", "12345", "12345", "dkjkd", 1000);
            bank.addNewEmployee("Ahmed", "12345", "12345", "12345", "dkjkd", 1000);
            Employee emp1 = bank.getEmployee(1);
            Console.WriteLine("Employee Name: {0} ", emp1.Name);
            bank.removeEmployee(1);
            Employee emp2 = bank.getEmployee(1);

            bank.addCustomer("Usman", "12345", "12345", "12345", "usman@gmail.com");
            bank.addCustomer("Haider", "12345", "12345", "12345", "haider@gmail.com");
            Customer cust1 = bank.getCustomer(1);
            Console.WriteLine("Customer Name: {0}", cust1.Name);
            cust1.account.deposit(500);
            cust1.account.withdraw(300);
            cust1.account.withdraw(1200); // throws error Amount Exceed Maximum Transaction Amount!
            cust1.account.withdraw(1000); // balance is 4200
            cust1.account.withdraw(1000); // balance is 3200
            cust1.account.withdraw(1000); // balance is 2200
            cust1.account.withdraw(1000); // balance is 1200
            cust1.account.withdraw(1000); // balance is 200
            cust1.account.withdraw(500);  // throws error insufficient funds
            cust1.account.display();


            bank.removeCustomer(1);
            Customer cust2 = bank.getCustomer(1);
        }
    }
}