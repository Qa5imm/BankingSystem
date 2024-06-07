namespace BankingSystem {
    public class Transaction(int new_amount, string new_type) : ICommon {
        public DateTime DateandTime { get; set; } = DateTime.Now;
        public int Amount { get; set; } = new_amount;
        public string Type { get; set; } = new_type;



        public void display() {
            Console.WriteLine($"Date: {DateandTime}, Amount: {Amount}, Type: {Type}");
        }
    }
}