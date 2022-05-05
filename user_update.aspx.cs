using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;

namespace ShoppingWebsite_ASP_NET
{
    public partial class user_update : System.Web.UI.Page
    {
        private string strCon;
        private SqlConnection con;
        private string id;
        protected void Page_Load(object sender, EventArgs e)
        {
            init();
            id = Request.QueryString["id"];
            //Response.Write(id);
        }

        protected void bt2_Click(object sender, EventArgs e)
        {
          
            if (id != "1"||id !=null)
            {

                Response.Redirect("~/user_center.aspx?id="+id);

            }
            else
            {

                Response.Redirect("~/admin_busi.aspx?id=1" );
            }

         

        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            string sql;
            SqlCommand cmd = new SqlCommand();
            if (tb1.Text != null)
            {
                sql = string.Format("update user_info set username = '{0}'  where id=" + id, tb1.Text);
                update(sql, cmd);
            }
            if (tb2.Text != null)
            {
                sql = string.Format("update user_info set pwd = '{0}'  where id=" + id, tb2.Text);
                update(sql, cmd);
            }
            if (tb3.Text != null)
            {
                sql = string.Format("update user_info set mail = '{0}'  where id=" + id, tb3.Text);
                update(sql, cmd);
            }
            int res = cmd.ExecuteNonQuery();
            if (res > 0)
            {
                Response.Write("<script>alert('修改成功！');</script>");
            }
            else
            {
                Response.Write("<script>alert('修改失败！');</script>");
            }

        }

        protected void update(string sql, SqlCommand cmd)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.CommandText = sql;
            cmd.Connection = con;
            cmd.ExecuteNonQuery();

        }

        private void init()
        {
            strCon = "Server=LAPTOP-11KDIIR8;Database=shoppingCar;Integrated Security=True";
            con = new SqlConnection(strCon);
        }
    }
}