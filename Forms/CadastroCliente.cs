using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_Terceiro_Semestre
{
    public partial class CadastroCliente : Form
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_principal mp = new Menu_principal();
            mp.ShowDialog();
        }

        private void bttCadastrarCliente_Click(object sender, EventArgs e)
        {
            string nome = "", ramo = "", cnpj = "", estado = "", email = "", senha = "";
            nome = txtNomeEmpresa.Text;
            ramo = txtRamo.Text;
            cnpj = txtCNPJ.Text;
            estado = txtEstado.Text;
            email = txtEmail.Text;
            senha = txtSenha.Text;
            bool ok = new ClienteBD().CadastrarBD(new Cliente());
            // limpar TextBox
            txtNomeEmpresa.Text = "";
            txtRamo.Text = "";
            txtCNPJ.Text = "";
            txtEstado.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";


        }

        private void bttCancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_principal mp = new Menu_principal();
            mp.ShowDialog();
        }

        private void CadastroCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
