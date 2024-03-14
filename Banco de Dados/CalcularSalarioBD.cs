using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_Terceiro_Semestre
{
    public class CalcularSalarioBD
    {
        //Estanciando Classes necessárias.
        ConexãoBD conexão = new ConexãoBD();
        SqlCommand cmd = new SqlCommand();

        public bool CalculoBD(CalcularSalario CS)
        {
            //Comando SQL de Calculo de salario
            cmd.CommandText = "INSERT INTO TBHolerite (SalarioBruto,SalarioLiquido,INSS,PIS,Drmd,Faltas,HorasDescontadas1,HorasAbonadas1) VALUES (@SalarioBruto,@SalarioLiquido ,@INSS, @PIS,@DRMD,@Faltas,@HorasDescontadas,@HorasAbonadas)";

            //Parâmetros de cadastro
            cmd.Parameters.AddWithValue("", CS.SalarioBruto);
            cmd.Parameters.AddWithValue("", CS.SalarioLiquido);
            cmd.Parameters.AddWithValue("", CS.Inss);
            cmd.Parameters.AddWithValue("",CS.Pis);
            cmd.Parameters.AddWithValue("",CS.Drmd);
            cmd.Parameters.AddWithValue("",CS.Faltas);
            cmd.Parameters.AddWithValue("",CS.HorasDescontadas1);
            cmd.Parameters.AddWithValue("",CS.HorasAbonadas1);

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
