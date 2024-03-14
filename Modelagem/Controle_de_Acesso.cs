using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pim_Terceiro_Semestre
{
    public class Controle_de_Acesso
        //Classe que e utilizada para formar três camadas de proteção para o login
    {
        public bool tem; // item utilizado para armazenar a resposata de maneira boleana
        public string mensagem = "";

        public bool Acesso(string Login, string Senha)
        {
            //Uma das partes da verificação do login e senha que são buscados no banco de dados para que seja realizado o login 

            ValidarLogin valida = new ValidarLogin();
            tem = valida.ValidarL(Login, Senha);
            if (valida.mensagem.Equals(""))
            {
                this.mensagem = valida.mensagem;
            }
            return tem;
        }
    }
}
