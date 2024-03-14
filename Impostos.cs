using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_Terceiro_Semestre
{
    public class Impostos 
        //Classe composta de todos os encargos obrigatorios do funcionario segundo a lei
    {

        //Claculo do desconto do Inss apartir da renda do funcionario seguindo as tabelas da receita federal com progressão de desconto variando ate 14% que e a taxa máxima de 2024
        CalcularSalario CS = new CalcularSalario();
        public static double CalcularDesconto(double salarioBruto)
        {
            //Calculo do inss do funcionario segundo o salario
            if (salarioBruto <= 1320.00) //Salário mínimo estipulado pelo governo federal suscetível a mudanças
            {
                return salarioBruto * 0.075;
            }
            else if (salarioBruto <= 2571.29)
            {
                return salarioBruto * 0.09;
            }
            else if (salarioBruto <= 3856.94)
            {
                return salarioBruto * 0.12;
            }
            else if (salarioBruto <= 7507.49)
            {
                return salarioBruto * 0.14;
            }
            else
            {
                return 7507.49 * 0.14;
            }
        }

        public class PIS
            //Taxa uninca para todos os cidadões 
        {
            CalcularSalario CS = new CalcularSalario();
            public static double CalcularDesconto(double salarioBruto)
            {
                return salarioBruto * 0.0065;
            }
        }

        public class Imposto
        {
        }
    }
}