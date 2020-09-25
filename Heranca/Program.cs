using Heranca.Entities;
using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            /*HERANÇA: É um tipo de associação que permite que uma classe herde dados e comportamento de outra.
             
            ** DEFINIÇÕES IMPORTANTES:
            - Relação "é-um"
            - Generalização/Especialização
            - Superclasse (classe base) / Subclasse (classe derivada)
            - Herança/Extensão
            - Herança é uma associação entre classes (e não entre objetos).
            
            * VANTAGENS:
            - Reuso: A herança irá permitir o reuso de atributos e métodos (dados e comportamento) na UML a representação de herança é a seta branca.
            - Polimorfismo

            * SINTAXE:
            - : (estende)
            - base (referência para a superclasse)
             */

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.0, 500.0);

            Console.WriteLine(account.Balance);
            //account.Balance = 200.0; nesse casso não pode ser acessado pois o set é inacessível por conta do protected definido na Classe Account.

        }
    }
}
