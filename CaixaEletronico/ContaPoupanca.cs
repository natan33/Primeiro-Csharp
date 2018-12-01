using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaWindowsFormds
{
    public class ContaPoupanca : Conta, Itributavel
    {
       

       
        public override double Saque(double valor)
        {
            base.saldo -= (valor + 0.10);
            return saldo;
        }


        // Estamos chamando o construtor da calsse pai que já faz a inicialização
        // do número e por isso o corpo do construtor pode ficar vazio.
        public ContaPoupanca(int numero) : base(numero)
        {

        }

        public ContaPoupanca()
        {
        }

        public override double DevolveSaldo()
        {
            return Saldo;
        }
        //Calcula oO tributo anual da ContaInvestimento
        public double CalculaTributo()
       
        {
            return this.Saldo * 0.03;
        }

        public double calculaTributo()
        {
            throw new NotImplementedException();
        }

      

    }
}




