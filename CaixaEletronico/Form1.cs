using ContaWindowsFormds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaEletronico
{
    public partial class Form1 : Form
    {

        private Conta[] contas;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            contas = new Conta[3];


            contas[0] = new ContaCorrente();
            contas[0].Numero = 1;
            contas[0].Saldo = 1234;
            contas[0].Cliente = new Cliente("Ismael", 098098098, "7477567", "Sergio");

            contas[1] = new ContaPoupanca();
            contas[1].Numero = 1;
            contas[1].Saldo = 379;
            contas[1].Cliente = new Cliente("Carlos", 1, "4547474", "Carlors");

            contas[2] = new ContaPoupanca();
            contas[2].Numero = 1;
            contas[2].Saldo = 2340;
            contas[2].Cliente = new Cliente("Julia", 23478923432, "235235442", "Aline");

            comboBox1.Items.Add(contas[0].Cliente.nome);
            comboBox1.Items.Add(contas[1].Cliente.nome);
            comboBox1.Items.Add(contas[2].Cliente.nome);



        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)

        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            {


                Conta conta = new ContaCorrente();
                Conta conta1 = new ContaCorrente();
                Conta conta2 = new ContaCorrente();

                contas[0] = new ContaCorrente();
                contas[0].Numero = 1;
                contas[0].Saldo = 1234;
                contas[0].Cliente = new Cliente("Ismael", 098098098, "7477567", "Sergio");

                contas[1] = new ContaPoupanca();
                contas[1].Numero = 2;
                contas[1].Saldo = 379;
                contas[1].Cliente = new Cliente("Carlos", 1, "4547474", "Carlors");

                contas[2] = new ContaPoupanca();
                contas[2].Numero = 3;
                contas[2].Saldo = 2340;
                contas[2].Cliente = new Cliente("Julia", 23478923432, "235235442", "Aline");

                int indice = Convert.ToInt32(textBox1.Text);
                Conta Contas = this.contas[indice];
                textNumero.Text = Convert.ToString(conta.Numero);
                textTitular.Text = Contas.Cliente.nome;
                textSaldo.Text = Convert.ToString(Contas.Saldo);

                comboBox1.Items.Add(contas[0].Cliente.nome);
                comboBox1.Items.Add(contas[1].Cliente.nome);
                comboBox1.Items.Add(contas[2].Cliente.nome);



            }
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {

           // double Saldo = Convert.ToDouble(textValor.Text);

            //Conta contas = new ContaCorrente();


            //double resultado = Convert.ToDouble(TxtSaldo.Text) + contas.Deposito(Convert.ToDouble(TxtValor.Text));

            //MessageBox.Show("Saldo Atual: " + Convert.ToString(textSaldo.Text) +
            //   "\n Saque: " + contas.Saque(Convert.ToDouble(textValor.Text)));

            contas[Convert.ToInt32(comboBox1.SelectedIndex)].Deposito(Convert.ToInt32(textValor.Text));
            textSaldo.Text = contas[Convert.ToInt32(comboBox1.SelectedIndex)].getSaldo().ToString();
        }

        private void textValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {

            //double Saldo = Convert.ToDouble(textValor.Text);

            // Conta contas = new ContaCorrente();


            //double resultado = Convert.ToDouble(textSaldo.Text) + contas.Deposito(Convert.ToDouble(textValor.Text));

            // MessageBox.Show("Saldo Atual: " + Convert.ToString(textSaldo.Text) +
            //"\nSaque: " + contas.Saque(Convert.ToDouble(textValor.Text))
            // + "\nSaldo atual: " + contas.Saque(Convert.ToDouble(textSaldo.Text)));


            contas[Convert.ToInt32(comboBox1.SelectedIndex)].Saque(Convert.ToInt32(textValor.Text));
            textSaldo.Text = contas[Convert.ToInt32(comboBox1.SelectedIndex)].getSaldo().ToString();


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        // Execultar toda vez que combobox foi selecionado
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            comboBox1.Items.Add(contas[0].Cliente.nome);
            comboBox1.Items.Add(contas[1].Cliente.nome);
            comboBox1.Items.Add(contas[2].Cliente.nome);

            int indice = comboBox1.SelectedIndex;
            Conta selecionada = contas[indice];
            textNumero.Text = Convert.ToString(selecionada.Numero);
            textTitular.Text = selecionada.Cliente.nome;
            textSaldo.Text = Convert.ToString(selecionada.Saldo);
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {

            ContaPoupanca contaPoupanca = new ContaPoupanca();
            contaPoupanca.Deposito(200.0);

            ContaInvestimento contaInvestimento = new ContaInvestimento();
            contaInvestimento.Deposito(300.0);

            TotalizadorDeTributos totalizador = new TotalizadorDeTributos();
            totalizador.Acumula(contaPoupanca);
            MessageBox.Show("Total: " + totalizador.total);
            totalizador.Acumula(contaInvestimento);
            MessageBox.Show("Total: " + totalizador.total);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}


