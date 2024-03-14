using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Pim_Terceiro_Semestre
{
    public class ValidarLogin
    {
        //Estanciando Classes necessárias.
        ConexãoBD conexão = new ConexãoBD();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public bool tem= false;
        public string mensagem = "";

        public bool ValidarL(string Login, string Senha)
        {
            // Procurar Login utilizado no banco de dados
            cmd.CommandText = "select * from TBAcesso where login = @Login and Senha = @Senha";
            cmd.Parameters.AddWithValue("@Login",Login);
            cmd.Parameters.AddWithValue("@Senha",Senha);

            //Conexão com o Banco de Dado

            try
            {
                //Conectar com o Banco de Dados
                cmd.Connection = conexão.conectar();

                //Executar o comando
                dr =cmd.ExecuteReader();
                if (dr.HasRows) // Verificar se foi encontrado esse o login e a senha
                {
                    tem = true;
                }

            }
            catch (SqlException)
            {
                mensagem = ("Erro de conexão com o Banco de Dados Tente Novamente!");
            }
            return tem;
        }
    }
}
