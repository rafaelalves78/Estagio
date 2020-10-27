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

        //Para sobrescrever o metodo na subclasse eu uso override:
        public override void Withdraw(double amount)
        {
            //Para aproveitar a implementação da superclasse eu uso a palavra base:
            base.Withdraw(amount);
            Balance -= 2.0;
        }
    }
}

