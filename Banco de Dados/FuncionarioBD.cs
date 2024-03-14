using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pim_Terceiro_Semestre
{
    public class FuncionarioBD
    {
        //Estanciando Classes necessárias.
        ConexãoBD conexão = new ConexãoBD();
        SqlCommand cmd = new SqlCommand();

        public  bool CadastrarFBD(Funcionario f)
        {
            //Comando SQL de cadastro da tabela Funcionário
            cmd.CommandText = "insert into TBFuncionario (Emperesa,Nome,Rg,Cpf,Pis,NcarteiraTB1,Nreservista1,Endereço,CEP1,SalarioBruto1,Senha) values (@Empresa,@Nome,@GR,@CPF,@PIS,@N° da CArteira de Trabalho,@N° da Reservista,@Endereço,@CEP,@Salario Brunto,@Senha)";

            //Parametros de cadastro
            cmd.Parameters.AddWithValue("", f.Empresa);
            cmd.Parameters.AddWithValue("", f.Nome);
            cmd.Parameters.AddWithValue("", f.Rg);
            cmd.Parameters.AddWithValue("", f.Cpf);
            cmd.Parameters.AddWithValue("", f.Pis);
            cmd.Parameters.AddWithValue("", f.NcateiraTB1);
            cmd.Parameters.AddWithValue("", f.Nreservista1);
            cmd.Parameters.AddWithValue("", f.Endereço);
            cmd.Parameters.AddWithValue("", f.CEP1);
            cmd.Parameters.AddWithValue("", f.SalarioBruto1);
            cmd.Parameters.AddWithValue("", f.SalarioLiquido1);
            cmd.Parameters.AddWithValue("", f.Senha);


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

        public bool Buscar(string CPF)
        {
            Funcionario f = new Funcionario();
            //busca 
            cmd.CommandText = "select * from TBFuncionario where CPF= @CPF";
            cmd.Parameters.AddWithValue("@CPF", CPF);
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
                    string Empresa = dataReader.GetString(0);
                    string Nome = dataReader.GetString(1);
                    string Rg = dataReader.GetString(2);
                    string Cpf = dataReader.GetString(3);
                    string Pis = dataReader.GetString(4);
                    string NcarteiraTB1 = dataReader.GetString(5);
                    string Nreservista1 = dataReader.GetString(6);
                    string Endereço = dataReader.GetString(7);
                    string CEP1 = dataReader.GetString(8);
                    string SalarioBruto1 = dataReader.GetString(9);
                    string SEnha = dataReader.GetString(10);
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

        public bool alterar(Funcionario f)
        {

            //comando sql de cadastro
            cmd.CommandText = "update tbCliente set (Nome,Ramo,Cnpj,Estado,Email,Senha) VALUES (@Nome,@Ramo,@CNPJ,@Email,@Senha)";

            //Parametros de atualização
            cmd.Parameters.AddWithValue("", f.Empresa);
            cmd.Parameters.AddWithValue("", f.Nome);
            cmd.Parameters.AddWithValue("", f.Rg);
            cmd.Parameters.AddWithValue("", f.Cpf);
            cmd.Parameters.AddWithValue("", f.Pis);
            cmd.Parameters.AddWithValue("", f.NcateiraTB1);
            cmd.Parameters.AddWithValue("", f.Nreservista1);
            cmd.Parameters.AddWithValue("", f.Endereço);
            cmd.Parameters.AddWithValue("", f.CEP1);
            cmd.Parameters.AddWithValue("", f.SalarioBruto1);
            cmd.Parameters.AddWithValue("", f.Senha);

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
        public bool excluir(string CPF)
        {
            cmd.CommandText = "delete from TBCliente where CPF= @CPF";
            cmd.Parameters.AddWithValue("@CPF", CPF);

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
