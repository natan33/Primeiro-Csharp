using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaWindowsFormds
{
    public abstract  class Conta
    {
    
        public int numero { get; set; }
      
        public double saldo { get; set; }
  
        public double saque { get; set; }

        private Cliente cliente = new Cliente();

        public Conta(int numero)
        {
            this.numero = numero;
        }

        public Conta()
        {
        }


        public int Numero { get => numero; set => numero = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Saque1 { get => saque; set => saque = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        

        public virtual double Saque(double Valor)
        {

            if (Saldo >= Valor)
            {
                Saldo = Saldo - Valor;
            }


            return Saldo;

        }

        public double Deposito(double ValorDeposito)
        {

            Saldo = Saldo + ValorDeposito;
            return Saldo;
        }

        public double getSaldo()
        {

            return Saldo;
        }

        public string Transferencia(Conta contaOrigem, Conta contaDestino, Double Valor)
        {
            if (contaOrigem.Saldo >= Valor)
            {
                contaOrigem.Saldo -= Valor;
                contaDestino.Saldo += Valor;


            }
            return "O saldo da conta origem é: " + contaOrigem.Saldo + "Valor transferido:" + Valor;
        
        }

        public abstract double DevolveSaldo();

      
           
        }

    }


