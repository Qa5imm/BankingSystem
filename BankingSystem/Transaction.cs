namespace BankingSystem {
    public class Transaction : ICommon{
        public DateTime DateandTime { get; set; } = DateTime.Now;
        public int Amount { get; set; }
        public string Type { get; set; }

        public Transaction(int new_amount, string new_type)
        {
            Amount = new_amount;
            Type = new_type;
        }

        public void display()
        {
            Console.WriteLine($"Date: {DateandTime}, Amount: {Amount}, Type: {Type}");
        }
    }
}