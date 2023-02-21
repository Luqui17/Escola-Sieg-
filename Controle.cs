using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EscolaSieg
{
    public class Controle
    {

        public bool tem=false;
        public string mensagem = "";
        public bool Acessar(string email, string senha)
        {
            Conexao con = new Conexao(); 
            tem = con.VerificarLogin(email,senha);
            if (!con.mensagem.Equals(""))
            {
                this.mensagem = con.mensagem;
            }
            
            return tem;
        }
    }
}