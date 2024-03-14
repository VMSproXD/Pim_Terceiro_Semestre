using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_Terceiro_Semestre
{
    public partial class EditarFuncionario : Form
    {
        FuncionarioBD funcionarioBD = new FuncionarioBD();
        ConexãoBD con = new ConexãoBD();
        SqlConnection cmd = new SqlConnection();
        public EditarFuncionario()
        {
            InitializeComponent();
        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            //Alteração da tela a partir do botão Voltar

            this.Hide();
            BuscarFuncionario bf = new BuscarFuncionario();
            bf.ShowDialog();
        }

        private void bttAttCadastro_Click(object sender, EventArgs e)
        {

        }

        private void bttCancelarCadastro_Click(object sender, EventArgs e)
        {
            //Cancelamento do cadastro e Alteração da tela a partir do botão Cancelar Cadastro

            this.Hide();
            BuscarFuncionario bf = new BuscarFuncionario();
            bf.ShowDialog();
        }

        private void EditarFuncionario_Load(object sender, EventArgs e)
        {

        }
    }
}
