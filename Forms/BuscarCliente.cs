using Microsoft.VisualBasic.Logging;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pim_Terceiro_Semestre
{
    public partial class BuscarCliente : Form
    {
        private string CNPJ = "";
        ConexãoBD conexão = new ConexãoBD();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void bttBuscarCliente_Click(object sender, EventArgs e)
        {
            // Mostrando dados da tabela utilizando Data Grind
            string conexao = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"Pim 3° Semestre\";Integrated Security=True;Connect Timeout=30";
            try
            {
                if (CNPJ =="")
                {
                    SqlConnection con = new SqlConnection(conexao);
                    con.Open();
                    DataTable dt = new DataTable();
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM TBCliente", con);
                    adapt.Fill(dt);
                    dataGridCliente.DataSource = dt;
                    con.Close();
                }
                else 
                {
                    SqlConnection con = new SqlConnection(conexao);
                    con.Open();
                    DataTable dt = new DataTable(CNPJ);
                    SqlDataAdapter adapt = new SqlDataAdapter("SELECT * FROM TBCliente where CNPJ =@CNPJ", con);
                    adapt.Fill(dt);
                    dataGridCliente.DataSource = dt;
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

        private void bttEditarCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarCliente editarCliente = new EditarCliente();
            editarCliente.ShowDialog();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
        }

        private void txtBuscarCliente_TextChanged(object sender, EventArgs e )
        {
            CNPJ = txtBuscarCliente.Text;
        }
    }
}
