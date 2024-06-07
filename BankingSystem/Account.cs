namespace BankingSystem {
    public class Account(int new_amount, int new_number, int new_max_transaction_amount) : ICommon {

        public int Amount { get; set; } = new_amount;
        public int Number { get; set; } = new_number;
        public int Max_transaction_amount { get; set; } = new_max_transaction_amount;

        public List<Transaction> Transactions { get; set; } = new List<Transaction>();

        public void deposit (int deposit_amount) {
            if (deposit_amount > Max_transaction_amount) {
                Console.WriteLine("Amount Exceed Maximum Transaction Amount!");
            }
            else {
                Amount += deposit_amount;
                Transactions.Add(new Transaction(deposit_amount, "Deposit"));

            }
        }

        public void withdraw (int withdraw_amount) {
            if (withdraw_amount > Max_transaction_amount) {
                Console.WriteLine("Amount Exceed Maximum Transaction Amount!");
            }
            else if (withdraw_amount > Amount) {
                Console.WriteLine("Insufficient Funds!");
            }
            else {
                Amount -= withdraw_amount;
                Transactions.Add(new Transaction(withdraw_amount, "Withdraw"));
            }
            
        }

        public void display() {
            Console.WriteLine($"Account Number: {Number}, Balance: {Amount}");
            Console.WriteLine("Transactions:");
            foreach (var transaction in Transactions)
            {
                transaction.display();
            }
        }

    }
}