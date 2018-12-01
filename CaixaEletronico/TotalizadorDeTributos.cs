using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaWindowsFormds
{
    class TotalizadorDeTributos 
    {
        public double total { get; set; }

        public void Acumula(ContaPoupanca contapoupanca)
        {
          total += contapoupanca.CalculaTributo();
        }
        public void Acumula(ContaInvestimento contaInvestimento)
        {
            total += contaInvestimento.CalculaTributo();
        }

        internal void Acumula(ContaPoupanca contaPoupanca, object contapoupanca)
        {
            throw new NotImplementedException();
        }

        internal void Acumula(object contaInvestimento)
        {
            throw new NotImplementedException();
        }
    }


}

