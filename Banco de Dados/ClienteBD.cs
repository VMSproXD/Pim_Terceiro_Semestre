using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Pim_Terceiro_Semestre
{
    public class ClienteBD
    {
        //Estanciando Classes necessárias.
        ConexãoBD conexão = new ConexãoBD();
        SqlCommand cmd = new SqlCommand();

        public bool CadastrarBD(Cliente c)
        {
            //Comando SQL de cadastro da tabela Cliente
            cmd.CommandText = "insert into TBCliente values nome=@Nome,ramo=@Ramo,cnpj=CNPJ,estdo=@Estado,email=@Email,senha=@Senha";

            //Parametros de cadastro
            cmd.Parameters.AddWithValue("", c.Nome);
            cmd.Parameters.AddWithValue("", c.Ramo);
            cmd.Parameters.AddWithValue("", c.Cnpj);
            cmd.Parameters.AddWithValue("", c.Estado);
            cmd.Parameters.AddWithValue("", c.Email);
            cmd.Parameters.AddWithValue("", c.Senha);

            //Conexão com o Banco de Dado

            try
            {
                //Conectar com o Banco de Dados
                cmd.Connection = conexão.conectar();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Desconectar com o Banco de Dados
                conexão.desconectar();

                //Mostrar menssagem de erro ou sucesso
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados Tente Novamente!");
            }
            return true;
        }

        public bool Buscar(string CNPJ)
        {
            Cliente c = new Cliente();
            //busca 
            cmd.CommandText = "select * from tbCliente where CNPJ= @CNPJ";
            cmd.Parameters.AddWithValue("@CNPJ", CNPJ);
            // tenta realizar a conexão com o BD
            // testa e recebe a conexão
            SqlConnection con = new SqlConnection();

            try
            {
                //Conectar com o Banco de Dados
                cmd.Connection = conexão.conectar();

                //Executar o comando
                SqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.Read())
                {
                    //adiciona cliente
                    string Nome = dataReader.GetString(0);
                    string Ramo = dataReader.GetString(1);
                    string Estado = dataReader.GetString(2);
                    string Email = dataReader.GetString(3);
                    string Senha = dataReader.GetString(4);
                }
                else // CLIENTE NÃO ENCONTRADO
                {
                    MessageBox.Show("Cliente não encontrado!");
                }

                //Desconectar com o Banco de Dados
                conexão.desconectar();

                //Mostrar menssagem de erro ou sucesso
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados Tente Novamente!");
            }
            return true;
        }

        public bool alterar(Cliente c)
        {

            //comando sql de cadastro
            cmd.CommandText = "update tbCliente set (Nome,Ramo,Cnpj,Estado,Email,Senha) VALUES (@Nome,@Ramo,@CNPJ,@Email,@Senha)";

            //Parametros de cadastro
            cmd.Parameters.AddWithValue("", c.Nome);
            cmd.Parameters.AddWithValue("", c.Ramo);
            cmd.Parameters.AddWithValue("", c.Cnpj);
            cmd.Parameters.AddWithValue("", c.Estado);
            cmd.Parameters.AddWithValue("", c.Email);
            cmd.Parameters.AddWithValue("", c.Senha);

            //Conexão com o Banco de Dado

            try
            {
                //Conectar com o Banco de Dados
                cmd.Connection = conexão.conectar();

                //Executar o comando
                cmd.ExecuteNonQuery();

                //Desconectar com o Banco de Dados
                conexão.desconectar();

                //Mostrar menssagem de erro ou sucesso
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro de conexão com o Banco de Dados Tente Novamente!");
            }
            return true;
        }
                public bool excluir(string CNPJ)
                {
                cmd.CommandText = "delete from TBCliente where CNPJ= @CNPJ";
                cmd.Parameters.AddWithValue("@CNPJ", CNPJ);

                //Conexão com o Banco de Dado

                try
                {
                    //Conectar com o Banco de Dados
                    cmd.Connection = conexão.conectar();

                    //Executar o comando
                    cmd.ExecuteNonQuery();

                    //Desconectar com o Banco de Dados
                    conexão.desconectar();

                    //Mostrar menssagem de erro ou sucesso
                    MessageBox.Show("Cadastro realizado com sucesso!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Erro de conexão com o Banco de Dados Tente Novamente!");
                }
                return true;
                }
    }
}
