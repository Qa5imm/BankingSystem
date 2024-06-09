namespace BankingSystem {
    public class SavingsAccount : Account {
        public double InterestRate { get; set; }

        public SavingsAccount(int new_amount, int new_number, int new_max_transaction_amount, double new_interest_rate)
            : base(new_amount, new_number, new_max_transaction_amount) {
            InterestRate = new_interest_rate;
        }

        public void ApplyInterest() {
            int interest = (int)(Amount * InterestRate);
            deposit(interest);
            Console.WriteLine($"Interest of {interest} applied to Savings Account {Number}");
        }

        public override void withdraw(int withdraw_amount) {
            if (withdraw_amount > Max_transaction_amount) {
                Console.WriteLine("Amount Exceed Maximum Transaction Amount!");
            } else if (withdraw_amount > Amount) {
                Console.WriteLine("Insufficient Funds!");
            } else {
                Amount -= withdraw_amount;
                Transactions.Add(new Transaction(withdraw_amount, "Withdraw"));
            }
        }

        public override void display() {
            Console.WriteLine($"Account Number: {Number}, Balance: {Amount}");
            int futureBalance = Amount + (int)(Amount * InterestRate);
            Console.WriteLine($"Interest Rate: {InterestRate}, Balance After Interest: {futureBalance}");
            Console.WriteLine("Transactions:");
            foreach (var transaction in Transactions) {
                transaction.display();
            }
        }
    }
}