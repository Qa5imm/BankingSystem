namespace BankingSystem {
    public class CurrentAccount : Account {
        public int OverdraftLimit { get; set; }

        public CurrentAccount(int new_amount, int new_number, int new_max_transaction_amount, int new_overdraft_limit)
            : base(new_amount, new_number, new_max_transaction_amount) {
            OverdraftLimit = new_overdraft_limit;
        }

        public override void withdraw(int withdraw_amount) {
            if (withdraw_amount > Max_transaction_amount) {
                Console.WriteLine("Amount Exceed Maximum Transaction Amount!");
            } else if (withdraw_amount > (Amount + OverdraftLimit)) {
                Console.WriteLine("Exceeds Overdraft Limit!");
            } else {
                Amount -= withdraw_amount;
                Transactions.Add(new Transaction(withdraw_amount, "Withdraw"));
            }
        }

        public override void display() {
            Console.WriteLine($"Account Number: {Number}, Balance: {Amount}");
            Console.WriteLine($"Overdraft Limit: {OverdraftLimit}");
            Console.WriteLine("Transactions:");
            foreach (var transaction in Transactions) {
                transaction.display();
            }
        }
    }
}