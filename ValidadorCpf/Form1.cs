using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidadorCpf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            string numeroCpf = maskedText.Text;

            if (numeroCpf.Length < 11)
            {
                MessageBox.Show("DIGITE O CPF NOVAMENTE");
                maskedText.Text = String.Empty;
            }

            if (ValidacaoCPF.Validacao(numeroCpf))
            {
                lblResultado.Text = "CPF VÁLIDO";
            }
            else
            {
                lblResultado.Text = "CPF INVÁLIDO";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            maskedText.Text = ("");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
