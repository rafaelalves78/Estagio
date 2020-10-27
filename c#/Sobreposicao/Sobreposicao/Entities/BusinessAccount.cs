namespace Heranca.Entities
{
    class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {

        }

        //No caso de herança tem que ser colocado os parâmetro da classe mãe:
        //Faço isso chamando o construtor da classe mae atraves do : base()
        public BusinessAccount(int number, string holder, double balance, double loanLimit)
            : base(number, holder, balance)
        {
            this.LoanLimit = loanLimit;
        }

        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                Balance += amount;
            }
        }
    }
}

