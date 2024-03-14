using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_Terceiro_Semestre
{
    public partial class Menu_principal : Form
    {
        public Menu_principal()
        {
            InitializeComponent();
        }
        private void bttCadastarCliente_Click(object sender, EventArgs e)
        {
            //Alteração da tela a partir da escolha do botão Cadastrar Cliente

            this.Hide();
            CadastroCliente cc = new CadastroCliente();
            cc.ShowDialog();
        }

        private void bttPesquisarCliente_Click(object sender, EventArgs e)
        {
            //Alteração da tela a partir da escolha do botão Pesquisar Cliente 

            this.Hide();
            BuscarCliente bc = new BuscarCliente();
            bc.ShowDialog();
        }

        private void bttCadastarFuncionario_Click(object sender, EventArgs e)
        {
            //Alteração da tela a partir da escolha do botão Cadastrar Funcionario

            this.Hide();
            CadastroFuncionario CF = new CadastroFuncionario();
            CF.ShowDialog();
        }

        private void bttPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            //Alteração da tela a partir da escolha do botão Pesquisar Funcionario

            this.Hide();
            BuscarFuncionario bf = new BuscarFuncionario();
            bf.ShowDialog();
        }

        private void bttGerarHolerite_Click(object sender, EventArgs e)
        {
            //Alteração da tela a partir da escolha do botão Gerar Holerite

            this.Hide();
            GerarHolerite gh = new GerarHolerite();
            gh.ShowDialog();
        }

        private void bttPequisarHolerite_Click(object sender, EventArgs e)
        {
            //Alteração da tela a partir da escolha do botão Pesquisar Holerite

            this.Hide();
            BuscarHolerite bh = new BuscarHolerite();
            bh.ShowDialog();

        }

        private void bttSair_Click(object sender, EventArgs e)
        {
            //Fechamento do programa apartir do Botão Sair

            Application.Exit();
        }

        private void Menu_principal_Load(object sender, EventArgs e)
        {

        }
    }
}
