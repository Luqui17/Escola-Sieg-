using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace EscolaSieg
{
    public class Cadastro
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;

        public Cadastro(string nome, string email, string senha)
        {
            //comando sql 
            cmd.CommandText = "insert into usuario (nome, email, senha) values (@nome, @email, @senha)";

            //parametros
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Usuário Cadastrado Com Sucesso !!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
                throw;
            }
        }
    }
}