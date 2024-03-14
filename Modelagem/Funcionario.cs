using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_Terceiro_Semestre
{
    public class Funcionario // Informações do funcionario nessesarias para o cadastro 
    {
        private int id;
        private string empresa = "";
        private string nome = "";
        private string rg = "";
        private string cpf = "";
        private string pis = "";
        private string NcateiraTB = "";
        private string Nreservista = "";
        private string endereço = "";
        private string CEP = "";
        private string SalarioBruto = "";
        private string SalarioLiquido = "";
        private string senha = "";

        public Funcionario() { } 
        // Metodo Construtor para a classe funcionario

        public Funcionario(int id, string empresa, string nome, string rg, string cpf, string pis, string ncateiraTB, string nreservista, string endereço, string cEP, string salarioBruto, string salarioLiquido, string senha)
        {
            this.Id = id;
            this.Empresa = empresa;
            this.Nome = nome;
            this.Rg = rg;
            this.Cpf = cpf;
            this.Pis = pis;
            NcateiraTB1 = ncateiraTB;
            Nreservista1 = nreservista;
            this.Endereço = endereço;
            CEP1 = cEP;
            SalarioBruto1 = salarioBruto;
            SalarioLiquido1 = salarioLiquido;
            this.Senha = senha;
        }

        public int Id { get => id; set => id = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Rg { get => rg; set => rg = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Pis { get => pis; set => pis = value; }
        public string NcateiraTB1 { get => NcateiraTB; set => NcateiraTB = value; }
        public string Nreservista1 { get => Nreservista; set => Nreservista = value; }
        public string Endereço { get => endereço; set => endereço = value; }
        public string CEP1 { get => CEP; set => CEP = value; }
        public string SalarioBruto1 { get => SalarioBruto; set => SalarioBruto = value; }
        public string SalarioLiquido1 { get => SalarioLiquido; set => SalarioLiquido = value; }
        public string Senha { get => senha; set => senha = value; }

        public override string ToString() 
            // Retorno da classe funcionario que sera utilizada para gravar as informações no banco de dados
        {
            return "\nNome: ," + Nome + "Empresa: " + Empresa + "\nRG: " + Rg + "\nCPF: " + Cpf + "N° da Carteira de Trabalho: " + NcateiraTB1 + "\nN° da reservista: " + Nreservista1 + "\nEndereço: " + Endereço + "\nCEP: " + CEP1 +"\nSalario Bruto: "+SalarioBruto1 +SalarioLiquido1+"\nSalario Liquido:"+"\nSenha: " + Senha;
        }

        public bool validaSenha(string l, string s) 
        {
            if (Cpf.Equals(l)&& Senha.Equals(s))
                return true;
                else return false;
        }
    }
}
