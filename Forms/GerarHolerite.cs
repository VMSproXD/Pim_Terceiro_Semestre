using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_Terceiro_Semestre
{
    public partial class GerarHolerite : Form
    {
        public GerarHolerite()
        {
            InitializeComponent();
        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            //Alteração da tela a partir da escolha do botão Voltar

            this.Hide();
            Menu_principal mp = new Menu_principal();
            mp.ShowDialog();
        }

        private void bttGerarHolerite_Click(object sender, EventArgs e)
        {
            //Geração do Holerite a partir do botão Gerar Holerite

            {
                BuscarDadosParaCalculo buscar = new BuscarDadosParaCalculo();
                SqlCommand cmd = new SqlCommand();
                string nome = txtNomeFuncionario.Text;
                string cpf = txtCPF.Text;

                if (!string.IsNullOrEmpty(nome) && !string.IsNullOrEmpty(cpf))
                {
                    //buscar.(nome, cpf);
                }
                else
                {
                    MessageBox.Show("Por favor, insira o nome e o CPF do funcionário.");
                }
            }

        }

        private void bttCancelarCalculo_Click(object sender, EventArgs e)
        {
            //Cancelamento do calculo e alteração da tela a partir do botão Cancelar Calculo

            this.Hide();
            Menu_principal mp = new Menu_principal();
            mp.ShowDialog();
        }

        private void GerarHolerite_Load(object sender, EventArgs e)
        {

        }
    }
}
