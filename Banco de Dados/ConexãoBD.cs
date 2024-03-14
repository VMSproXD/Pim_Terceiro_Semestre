using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Pim_Terceiro_Semestre
{
    public class ConexãoBD
    {
        //Classe utilizada para conexção e desconexção do servidor/Banco de dados
        SqlConnection con = new SqlConnection();

        //Construtor
        public ConexãoBD() 
        {
            con.ConnectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=\"Pim 3° Semestre\";Integrated Security=True;Connect Timeout=30";
        }

        //Metodo Conectar
        public SqlConnection conectar() 
        {
            if (con.State == System.Data.ConnectionState.Closed) 
            {
                con.Open();
            }
            return con;
        }

        //Metodo  Desconectar
        public void desconectar() 
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }
    }
}
