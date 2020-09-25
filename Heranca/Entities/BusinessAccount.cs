namespace Heranca.Entities
{
    class BusinessAccount : Account //Aqui foi declarado a herança dizendo que a classe BusinessAccount EXTENDE(:) para a classe Account, ou seja essa classe terá tudo que a outra classe tem.
    {
        public double LoanLimit { get; set; }

        public BusinessAccount()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double loanLimit) : base(number, holder, balance) //Aqui é utilizado o (: base) para utilizar o construtor da superclasse Account aplicando o reuso de código, necessitando depois declarar apenas a atribuição pertencente apenas a essa classe(LoanLimit).
        {
            LoanLimit = loanLimit;
        }

        public void Loan (double amount)
        {
            if (amount <= LoanLimit) //Testa se a quantia do emprestimo é menor ou igual ao limite de empréstimo, para que se for verdadeiro o resultado aí sim será incluido o valor do empréstimo ao saldo da conta.
            {
                Balance += amount; //Acrescenta a quantia do empréstimo ao saldo da conta
            }
        }
    }
}
