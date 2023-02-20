using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EscolaSieg
{
    public partial class TelaCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Response.Write("<script>console.log('Lcuas');</script>");
            botaoCadastrar.ServerClick += new EventHandler(this.CadastrarButton);
        }
        private void CadastrarButton(object sender, EventArgs e)
        {
            Page.Response.Write("<script>console.log('"+nome.Value+"');</script>");
            Page.Response.Write("<script>console.log('" + email.Value + "');</script>");
            Page.Response.Write("<script>console.log('" + senha.Value + "');</script>");
            Cadastro cad = new Cadastro(nome.Value, email.Value, senha.Value);
        }
        
    }
} 