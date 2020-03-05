namespace BudgetTrekker.Models
{
    public class AccountData
    {
        public int ID { get; set; } = 1;
        public string Name { get; set; } = "Название счета";
        public int Index { get; set; } = 1; // номер в списке счетов
        public string CardNumber { get; set; } = "0";
        public double CashSum { get; set; } = 0;

  
        public AccountData(string name, int index, string card_number, double cash_sum)
        {
            this.Name = name;
            this.Index = index;
            this.CardNumber = card_number;
            this.CashSum = cash_sum;
        }

        public AccountData() { }
    }
}