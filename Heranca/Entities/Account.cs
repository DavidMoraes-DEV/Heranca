namespace Heranca.Entities
{
    class Account
    {
        public int Number { get; protected set; } //A palavra "protected" permite que o valor seja alterado somente pelas SubClasses(BusinessAccount) da SuperClasse(Account), sendo que então na classe do programa principal não é possível realizar essa alteração. 
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

        public void Withdraw (double amount)
        {
            Balance -= amount;
        }

        public void Deposit (double amount)
        {
            Balance += amount;
        }
    }
}
