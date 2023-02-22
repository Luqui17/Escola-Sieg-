using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace EscolaSieg
{
    public partial class TelaInicial : System.Web.UI.Page
    {
        public Int32 IdProduto
        {
            get
            {
                if (ViewState["IdProduto"] != null)
                    return Convert.ToInt32(ViewState["IdProduto"]);

                return 0;
            }
            set
            {
                ViewState["IdProduto"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            int Id;
            //acessarAluno.ServerClick += new EventHandler(this.AcessarAluno);

            try
            {
                Page.Response.Write("<script>console.log('Lcuas');</script>");
                Conexao con = new Conexao();
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = @"Data Source=DESKTOP-HP94V7G\SQLEXPRESS;Initial Catalog=escola;Integrated Security=True";
                    cn.Open();

                    var sqlQuery = "select * from Alunos";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            //if (!Page.IsPostBack)
            //{
            //    if (Request.QueryString["IdProduto"] != null)
            //    {
            //        this.GridView1(Convert.ToInt32(Request.QueryString["IdProduto"]));
            //        this.IdProduto = Convert.ToInt32(Request.QueryString["IdProduto"]);
            //    }
            //}
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Write("<script>console.log('Lcuas');</script>");
                Conexao con = new Conexao();
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = @"Data Source=DESKTOP-HP94V7G\SQLEXPRESS;Initial Catalog=escola;Integrated Security=True";
                    cn.Open();

                    var sqlQuery = "select * from Alunos where Turma = '"+TextBox1.Text+ "'" ;
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //var id = Convert.ToInt32(GridView1.Rows[GridView1.CurrentCell.RowIndex])
        }

        protected void AcessarAluno(object sender, EventArgs e)
        {
            Page.Response.Redirect("CadastroAluno.apx");
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            Page.Response.Redirect("CadastroAluno.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void gvAlunosTV_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }

    }
}