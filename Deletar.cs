using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace EscolaSieg
{
    public class Deletar
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public Deletar(int id)
        {
            cmd.CommandText = "DELETE from Alunos WHERE id=@id;";
           
            cmd.Parameters.AddWithValue("@nome", id);

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