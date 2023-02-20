using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EscolaSieg
{
    public partial class TelaDeLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            botaoLogin.ServerClick += new EventHandler(this.LoginButton);
        }
        private void LoginButton(object sender, EventArgs e)
        {
            Page.Response.Write("<script>alert('teste');</script>");
            Page.Response.Write("<script>console.log('teste');</script>");
            Controle controle = new Controle();
            controle.Acessar(email.Value, senha.Value);
            if (controle.tem)
            {
                MessageBox.Show("Logado com Sucesso");
            }
            else
            {
                MessageBox.Show("Usuário não encontrado, verifique login e senha");
            }
        }
    }
}