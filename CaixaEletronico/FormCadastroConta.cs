﻿using ContaWindowsFormds;
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
    public partial class FormCadastroConta : Form
    {
        public FormCadastroConta()
        {
            InitializeComponent();
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            Conta c = new ContaPoupanca();
            c.Numero = Convert.ToInt16(TextBoxNumero);

        }

        private void FormCadastroConta_Load(object sender, EventArgs e)
        {

        }
    }
}
