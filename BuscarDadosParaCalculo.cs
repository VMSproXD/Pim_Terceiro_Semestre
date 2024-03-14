using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Pim_Terceiro_Semestre
{
    public class BuscarDadosParaCalculo
        // Classe utilizada para busca de dados no servidor para efetuar o calculo do salario do funcionario
    {
        static void BuscarNoBanco(string nome, string cpf)
        {

            try
            {
                ConexãoBD con = new ConexãoBD();
                SqlCommand cmd = new SqlCommand();
                SqlDataReader leitor = cmd.ExecuteReader();
                con.Open();

                // Sera utilizado o Cpf da pessoa e o nome para fazer a busca sendo o cpf a chave primaria da pesquisa

                cmd.CommandText = "SELECT * FROM TBFuncionario WHERE Nome = @Nome AND CPF = @CPF";
                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@CPF", cpf);


                if (leitor.Read())
                {

                    //metodo de leitura dos dados para serem apresentados
                    double salarioBruto = leitor.GetDouble(leitor.GetOrdinal("SalarioBruto"));
                    double descontoINSS = leitor.GetDouble(leitor.GetOrdinal("INSS"));
                    double descontoPIS = leitor.GetDouble(leitor.GetOrdinal("PIS"));
                    double salarioLiquido = leitor.GetDouble(leitor.GetOrdinal("SalarioLiquido"));
                }
                else
                {
                    // retorno da busca em caso de ela ser bem sucedida
                    MessageBox.Show("Funcionário não encontrado.");
                }

            }
            catch (Exception ex)
            {
                //retorno da busca em caso dela não ser bem sucedida
                MessageBox.Show("Erro ao buscar no banco de dados: " + ex.Message);
            }
            finally
            {
                ConexãoBD con = new ConexãoBD();
                con.desconectar();
            }
        }
    }
}
