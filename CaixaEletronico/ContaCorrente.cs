using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  ContaWindowsFormds
{
  class ContaCorrente : Conta
    {

     public override double DevolveSaldo()
        {
            return Saldo;
        }

    }
}
