using System;
using System.Collections.Generic;   
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaWindowsFormds
{   // Essa classe tem que ser abstrata
    public class ContaInvestimento : Conta, Itributavel
    {   //Calcula oO tributo anual da ContaInvestimento
        public double CalculaTributo()
        {

 
            return this.Saldo * 0.05;
        }

        public double calculaTributo()
        {
            throw new NotImplementedException();
        }

        public override double DevolveSaldo()
        {
            throw new NotImplementedException();
        }
    }


}
        
            
    

