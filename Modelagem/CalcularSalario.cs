using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pim_Terceiro_Semestre
{
    public class CalcularSalario
    {
        private float salarioBruto;
        private float salarioLiquido;
        private float Impostos;
        private float faltas;
        private float HorasDescontadas;
        private float HorasAbonadas;

        public CalcularSalario(float salarioBruto, float salarioLiquido, float impostos, float faltas, float horasDescontadas, float horasAbonadas)
        {
            this.SalarioBruto = salarioBruto;
            this.SalarioLiquido = salarioBruto-impostos-faltas;
            Impostos1 = impostos;
            this.Faltas = faltas;
            HorasDescontadas1 = horasDescontadas;
            HorasAbonadas1 = horasAbonadas;
        }

        public float SalarioBruto { get => salarioBruto; set => salarioBruto = value; }
        public float SalarioLiquido { get => salarioLiquido; set => salarioLiquido = value; }
        public float Impostos1 { get => Impostos; set => Impostos = value; }
        public float Faltas { get => faltas; set => faltas = value; }
        public float HorasDescontadas1 { get => HorasDescontadas; set => HorasDescontadas = value; }
        public float HorasAbonadas1 { get => HorasAbonadas; set => HorasAbonadas = value; }

        public override string ToString()
        {
            return "Salario Bruto:"+SalarioBruto+"Salario Liquido:"+SalarioLiquido+"Impostos:"+Impostos+"Faltas:"+Faltas;
        }

    }
}
