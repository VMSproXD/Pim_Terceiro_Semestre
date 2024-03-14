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
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        private void bttAttCadastro_Click(object sender, EventArgs e)
        {

        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            //Alteração da tela a partir do botão Voltar

            this.Hide();
            BuscarCliente bc = new BuscarCliente();
            bc.ShowDialog();
        }

        private void bttCancelarCadastro_Click(object sender, EventArgs e)
        {
            //Cancelamento do cadastro e alteração da tela a partir do botão Cancelar cadastro
            this.Hide();
            BuscarCliente bc = new BuscarCliente();
            bc.ShowDialog();
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
