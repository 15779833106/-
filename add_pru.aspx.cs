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
    public partial class add_pru : System.Web.UI.Page
    {
        string strCon;
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/admin_bu.aspx?id=1");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            init();
            string sql = string.Format("insert into all_product(product_num,product_name,product_price,product_buy_num,product_img_url,product_kinds)" +
                " values('" + tx1.Text+"', '" + tx2.Text + "', '" + tx3.Text + "', '" + tx4.Text +"', '" + tx5.Text + "', '" + tx6.Text + "')");
            SqlCommand cmd = new SqlCommand();
            oper(sql, cmd);
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

        protected void oper(string sql, SqlCommand cmd)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.CommandText = sql;
            cmd.Connection = con;
        }

        private void init()
        {
            strCon = "Server=LAPTOP-11KDIIR8;Database=shoppingCar;Integrated Security=True";
            con = new SqlConnection(strCon);
        }
    }
}