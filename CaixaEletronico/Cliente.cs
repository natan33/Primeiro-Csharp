using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaWindowsFormds
{
    public class Cliente
    {
        

        public string nome { get; private set; }
        public Int64 cpf { get; private set; }
        public string rg { get; private set; }
        public string endereco { get; private set; }
        public Cliente(string nome, Int64 cpf, string rg, string endereco)
        {

            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.endereco = endereco;

        }

        public Cliente()
        {
        }

        
    }
    
      
    }

