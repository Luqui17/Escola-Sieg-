using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace EscolaSieg
{
    public class Alunos
    {
        Conexao conexao = new Conexao();
        SqlCommand cmd = new SqlCommand();
        public string mensagem;

        public Alunos(string nome,string CPF, string idade, string turma)
        {
            //comando sql 
            cmd.CommandText = "insert into Alunos (Nome, cpf, DataNascimento, Turma) values (@Nome, @CPF, @DataNascimento, @Turma)";

            //parametros
            cmd.Parameters.AddWithValue("@Nome", nome);
            cmd.Parameters.AddWithValue("@CPF", CPF);
            cmd.Parameters.AddWithValue("@DataNascimento", idade);
            cmd.Parameters.AddWithValue("@Turma", turma);

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();
                conexao.Desconectar();
                MessageBox.Show("Aluno Cadastrado Com Sucesso !!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro ao tentar se conectar com o banco de dados");
                throw;
            }
        }
    }
}