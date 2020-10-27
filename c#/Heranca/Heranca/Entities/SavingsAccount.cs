namespace Heranca.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(int number, string holder, double balance, double interestRate) 
            : base(number, holder, balance)
        {
            this.InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            this.Balance += this.Balance * this.InterestRate;
        }
    }
}
