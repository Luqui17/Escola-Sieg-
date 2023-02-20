using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace EscolaSieg
{
    public class Conexao
    {

        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        public string mensagem="";
        public bool tem = false;
        //Construtor
        public Conexao()
        {
            con.ConnectionString = @"Data Source=DESKTOP-119IQ90\SQLEXPRESS;Initial Catalog=escola;Integrated Security=True";
        
        }
        //MetodoConectar

        public SqlConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        //MetodoDesconectar
        public void Desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }
        public bool VerificarLogin(string email, string senha)
        {
            //Comandos Sql verificar se tem no banco de dados
            cmd.CommandText = "select * from usuario where email = @email and senha = @senha;";
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                cmd.Connection = conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }
            }
            catch (SqlException)
            {
                this.mensagem = "Erro com banco de dados";
            }
            return tem;
        }
    }
}