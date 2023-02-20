using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EscolaSieg
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Response.Write("<script>console.log('Lcuas');</script>");
            botaoCadastrar.ServerClick += new EventHandler(this.CadastrarButton);
        }
        private void CadastrarButton(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(email.Value, senha.Value);
            if (controle.tem)
            {
                MessageBox.Show("Logado com Sucesso");
                Page.Response.Redirect("TelaInicial.aspx");
            }
            else
            {
                MessageBox.Show("Usuário não encontrado, verifique login e senha");
            }
        }
    }
}