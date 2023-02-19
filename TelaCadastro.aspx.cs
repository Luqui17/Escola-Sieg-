using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EscolaSieg
{
    public partial class TelaCadastro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BotaoCadastrar(object sender, EventArgs e)
        {
            Cadastro cad = new Cadastro(nome.Value,email.Value,senha.Value);
        }
    }
}