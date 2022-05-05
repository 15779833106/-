using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingWebsite_ASP_NET
{
    public partial class user_center : System.Web.UI.Page
    {
        private string id = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            string strCon = "Server=LAPTOP-11KDIIR8;Database=shoppingCar;Integrated Security=True";
            SqlConnection sqlcon = new SqlConnection(strCon);
            sqlcon.Open();
            id = Request.QueryString["id"];   //这个要是接受登录界面传递过来的id值。

            string sql = string.Format("select username from user_info where id= " + Convert.ToInt32(id));

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = sqlcon;
            cmd.CommandText = sql;
            lb1.Text = (string) cmd.ExecuteScalar();
            SqlDataAdapter sqlda = new SqlDataAdapter("select * from user_pru where userid = " + Convert.ToInt32(id), sqlcon);
            DataSet myds = new DataSet();
            sqlda.Fill(myds, "tb");
            GV1.DataSource = myds.Tables["tb"];
            GV1.DataBind();
        }


        protected void bt1_Click1(object sender, EventArgs e)
        {
            string url = "~/user_update.aspx?id=" + id;
            Response.Redirect(url);
        }

        protected void bt3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HappyShop.aspx?id=" + id);

        }

        protected void center1_Click(object sender, EventArgs e)
        {
            if (id!=null&& id != "1")
            {
                Response.Write("<script>alert('亲，你不是管理员,不可管理用户哟！')</Script>");

            }
            else
            {
                Response.Redirect("~/admin_bu.aspx?id=" + id);
            }
        }

        protected void car_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/buy.aspx?id=" + id);
        }
    }
}