namespace BankingSystem {
    public abstract class Account : ICommon {
        protected int Amount { get; set; }
        protected int Number { get; set; }
        protected int Max_transaction_amount { get; set; }

        protected List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public Account(int new_amount, int new_number, int new_max_transaction_amount) {
            Amount = new_amount;
            Number = new_number;
            Max_transaction_amount = new_max_transaction_amount;
        }

        public void deposit(int deposit_amount) {
            if (deposit_amount > Max_transaction_amount) {
                Console.WriteLine("Amount Exceed Maximum Transaction Amount!");
            } else {
                Amount += deposit_amount;
                Transactions.Add(new Transaction(deposit_amount, "Deposit"));
            }
        }

        public abstract void withdraw(int withdraw_amount);

        public abstract void display();
    }
}