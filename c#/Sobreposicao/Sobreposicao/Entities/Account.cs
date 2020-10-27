namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        //Para indicar que um metodo pode ser sobreposto na subclasse tem que colocar a palavra virtual:
        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

