using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Pim_Terceiro_Semestre
{
    public partial class CadastroFuncionario : Form
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        private void bttCadastarFuncionario_Click(object sender, EventArgs e)
        {
            string Empresa="", Nome="", RG="", CPF="", PIS="", NdaCarteiradeTrabalho="", NdaReservista="", Endereço="", CEP="", SalarioBruto="", Senha="";
            Empresa = txtEmpresa.Text;    
            Nome = txtNome.Text;
            RG = txtRG.Text;
            CPF = txtCPF.Text;
            PIS = txtPIS.Text;
            NdaCarteiradeTrabalho = txtCarteira.Text;
            NdaReservista = txtReservista.Text;
            Endereço = txtEndereço.Text;
            CEP = txtCPF.Text;
            SalarioBruto= txtSalarioBruto.Text;
            Senha = txtSenha.Text;
            bool ok = new FuncionarioBD().CadastrarFBD(new Funcionario());
            // limpar TextBox
            txtEmpresa.Text = "";
            txtNome.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtPIS.Text = "";
            txtCarteira.Text = "";
            txtReservista.Text = "";
            txtEndereço.Text = "";
            txtCEP.Text = "";
            txtSalarioBruto.Text = "";
            txtSenha.Text = "";




        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_principal mp = new Menu_principal();
            mp.ShowDialog();
        }

        private void bttCancelarCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_principal mp = new Menu_principal();
            mp.ShowDialog();
        }

        private void CadastroFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
