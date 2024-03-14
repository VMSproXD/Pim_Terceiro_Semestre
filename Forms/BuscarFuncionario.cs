using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_Terceiro_Semestre
{
    public partial class BuscarFuncionario : Form
    {
        private string CPF = "";
        public BuscarFuncionario()
        {
            InitializeComponent();
        }

        private void bttProcurarFuncionario_Click(object sender, EventArgs e)
        {

            // Mostrando dados da tabela utilizando Data Grind
            string conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"Pim 3° Semestre\";Integrated Security=True;Connect Timeout=30";
            try
            {
                if (CPF == "")
                {
                    SqlConnection con = new SqlConnection(conexao);
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM TBFuncionario", con);
                    adapt.Fill(dt);
                    dataGridFuncionario.DataSource = dt;
                    con.Close();
                }
                else
                {
                    SqlConnection con = new SqlConnection(conexao);
                    con.Open();
                    DataTable dt = new DataTable(CPF);
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM TBFuncionario where CPF = @CPF", con);
                    adapt.Fill(dt);
                    dataGridFuncionario.DataSource = dt;
                    con.Close();
                }
            }
            catch
            {
                throw;
            }

        }

        private void bttVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_principal mp = new Menu_principal();
            mp.ShowDialog();
        }

        private void bttEditarFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarFuncionario EF = new EditarFuncionario();
            EF.ShowDialog();
        }

        private void txtBuscarFuncionario_TextChanged(object sender, EventArgs e)
        {
            CPF= txtBuscarFuncionario.Text;
        }
    }
}
