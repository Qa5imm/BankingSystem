namespace BankingSystem
{
    public class Bank(string bankName, int branchCode) : ICommon
    {
        public string bankName { get; set; } = bankName;
        public int branchCode { get; set; } = branchCode;
        public int acc = 1110;
        public int empIter = 0;
        public int customerIter = 0;
        public List<Employee> employee { get; set; } = new List<Employee>();
        public List<Customer> customers { get; set; } = new List<Customer>();
        public virtual void display()
        {
            Console.WriteLine("Welcome to {0} Banking System.", bankName);
        }
        public void addNewEmployee(string name, string cnic, string phone, string address, string jobTitle, int salary)
        {
            employee.Add(new Employee(++empIter, name, cnic, phone, address, jobTitle, salary));
            Console.WriteLine("Employee with ID: {0} added", empIter);
        }
        public void removeEmployee(int id)
        {
            int idx = employee.FindIndex(employee => employee.Id == id);
            if (idx > -1)
            {
                employee.RemoveAt(idx);
                Console.WriteLine("Employee Removed");
            }
            else
            {
                Console.WriteLine("Employee doesnt exist");
            }
        }
        public Employee getEmployee(int id)
        {
            int idx = employee.FindIndex(employee => employee.Id == id);
            if (idx > -1)
            {
                return employee[idx];
            }
            Console.WriteLine("Employee doesnt exist");
            return null;
        }
        public void addCustomer(string name, string cnic, string phone, string address, string email)
        {
            while (true) {
                Console.Write("Select Account Type:\n1. Savings Account\n2.Current Account\n");
                string accType = Console.ReadLine();
                if (accType != null && (accType == "1" || accType == "2")) {
                    customers.Add(new Customer(++customerIter, name, cnic, phone, address, email, accType, ++acc));
                    break;
                }
            }
        }
        public void removeCustomer(int id)
        {
            int idx = customers.FindIndex(customer => customer.Id == id);
            if (idx > -1)
            {
                customers.RemoveAt(idx);
                Console.WriteLine("Customer Removed");
            }
            else
            {
                Console.WriteLine("Customer doesnt exist");
            }
        }
        public Customer getCustomer(int id)
        {
            int idx = customers.FindIndex(customer => customer.Id == id);
            if (idx > -1)
            {
                return customers[idx];
            }
            Console.WriteLine("Customer doesnt exist");
            return null;
        }
    }
}