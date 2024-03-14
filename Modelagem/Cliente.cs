using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Pim_Terceiro_Semestre
{
    
    public class Cliente
    {
        //Classe com  os dados nessesarios para o cadastro do Cliente 

        private int id;
        private string nome = "";
        private string ramo = "";
        private string cnpj = "";
        private string estado = "";
        private string email = "";
        private string senha = "";

        public Cliente() { }
        public Cliente(int id, string nome, string ramo, string cnpj, string estado, string email, string senha)
        {
            this.Id = id;
            this.Nome = nome;
            this.Ramo = ramo;
            this.Cnpj = cnpj;
            this.Estado = estado;
            this.Email = email;
            this.Senha = senha;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Ramo { get => ramo; set => ramo = value; }
        public string Cnpj { get => cnpj; set => cnpj = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }

        public override string ToString()
        {
            //Retorno da classe para gravação no banco de dados

            return "\nNome: " + nome + "\nRamo: " + ramo + "\nCNPJ: " + cnpj + "Estado: " + estado + "Email: " + email +"Senha: " + senha;
        }

        public bool validaSenha(string l, string s) 
        {
            if (cnpj.Equals(l) && senha.Equals(s))
                return true;
            else return false;
        }
    }
}
