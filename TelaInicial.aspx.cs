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
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Write("<script>console.log('Lcuas');</script>");
                Conexao con = new Conexao();
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = @"Data Source=DESKTOP-119IQ90\SQLEXPRESS;Initial Catalog=escola;Integrated Security=True";
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
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Page.Response.Write("<script>console.log('Lcuas');</script>");
                Conexao con = new Conexao();
                using (SqlConnection cn = new SqlConnection())
                {
                    cn.ConnectionString = @"Data Source=DESKTOP-119IQ90\SQLEXPRESS;Initial Catalog=escola;Integrated Security=True";
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
    }
}