using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaWindowsFormds
{
   public class TotalizadorDeContas
    {
        public double valorTotal { get; private set; }

        public void Soma (Conta conta)
        {
            valorTotal += conta.saldo;
        }
  
                    
       

    }
}
