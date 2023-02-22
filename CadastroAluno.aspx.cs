using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscolaSieg
{
    public partial class CadastroAluno : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           botaoAluno.ServerClick += new EventHandler(this.AlunoButton);
        }
        private void AlunoButton(object sender, EventArgs e)
        {
            Alunos aluno = new Alunos(nome.Value, cpf.Value, data.Value, turma.Value);
        }
    }
}