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
    public partial class admin_busi : System.Web.UI.Page
    {
        string strCon;
        string id = null;
        SqlConnection con = new SqlConnection();

        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["id"];
            init();
            con.Open();
            string sql = "select username from user_info where id=1";
            string name = (string)find(sql);
            lb1.Text = name;

            if (!IsPostBack)
            {
                Bind();
            }
        }


        protected void oper(string sql, SqlCommand cmd)
        {
            if (con.State != ConnectionState.Open)
                con.Open();
            cmd.CommandText = sql;
            cmd.Connection = con;
        }
        public object find(string sql)
        {
            //自动释放资源
            SqlCommand cmd = new SqlCommand();
            oper(sql, cmd);
            return cmd.ExecuteScalar();
        }

        private void init()
        {
            strCon = "Server=LAPTOP-11KDIIR8;Database=shoppingCar;Integrated Security=True";
            con = new SqlConnection(strCon);
        }

        private void Bind()
        {
            SqlDataAdapter sqlda1 = new SqlDataAdapter("select * from all_product", con);
            DataSet myds1 = new DataSet();
            sqlda1.Fill(myds1, "tb1");
            GV2.DataSource = myds1.Tables["tb1"];
            GV2.DataBind();
        }
        protected void GV2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = this.GV2.DataKeys[e.RowIndex].Value.ToString(); 
            Response.Write(id);
            string sql = string.Format("delete from all_product where product_num = '" + id + "'");
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
            Bind();
        }

        protected void GV2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GV2.EditIndex = e.NewEditIndex;//GridView编辑项索引等于单击行的索引
            Bind();
        }

        //protected void GV2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        //{
        //    string id = this.GV2.DataKeys[e.RowIndex].Value.ToString();
        //    // ((TextBox)(GridView1.Rows[i].Cells[1].Controls[0]).FindControl("TextBox1")).Text.Trim ().ToString ())
        //    //GridView1.Rows[GridView1.EditIndex].Cells[1].Controls[0].GetType().ToString();
        //    //((TextBox)(GV2.Rows[GV2.EditIndex].Cells[1].Controls[1])).Text;
        //    //((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
        //    // ((TextBox)(gv_Emplogin.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
        //    //string cell1 = ((TextBox)(GV2.Rows[e.RowIndex].Cells[1].Controls[0])).Text.ToString().Trim();
        //    //string cell2 = ((TextBox)(GV2.Rows[e.RowIndex].Cells[2].Controls[0])).Text.ToString().Trim();
        //    //string cell3 = ((TextBox)(GV2.Rows[e.RowIndex].Cells[3].Controls[0])).Text.ToString().Trim();
        //    //string cell4 = ((TextBox)(GV2.Rows[e.RowIndex].Cells[4].Controls[0])).Text.ToString().Trim();
        //    //string cell1 = ((TextBox)(GV2.Rows[GV2.EditIndex].Cells[1].Controls[0])).Text;
        //    //string cell2 = ((TextBox)(GV2.Rows[GV2.EditIndex].Cells[2].Controls[0])).Text;
        //    //string cell3 = ((TextBox)(GV2.Rows[GV2.EditIndex].Cells[3].Controls[0])).Text;
        //    //string cell4 = ((TextBox)(GV2.Rows[GV2.EditIndex].Cells[4].Controls[0])).Text;
        //    string cell1 = ((TextBox)(GV2.Rows[1].Cells[1].Controls[0]).FindControl("name")).Text.Trim().ToString();
        //    string cell2 = ((TextBox)(GV2.Rows[2].Cells[2].Controls[0]).FindControl("price")).Text.Trim().ToString();
        //    string cell3 = ((TextBox)(GV2.Rows[3].Cells[3].Controls[0]).FindControl("num")).Text.Trim().ToString();
        //    string cell4 = ((TextBox)(GV2.Rows[4].Cells[4].Controls[0]).FindControl("kinds")).Text.Trim().ToString();

        //    SqlCommand cmd = new SqlCommand();
        //    string sql = string.Format("update all_product set product_name = '{0}', product_price = '{1}', product_buy_num = '{2}' ,product_kinds = '{3}' where product_num = '{4}' ", cell1, cell2, Convert.ToInt32(cell3), cell4, id);
        //    oper(sql, cmd);
        //    Response.Write(sql);
        //    Response.Write(cmd.ExecuteNonQuery().ToString());

        //    int res = Convert.ToInt32(cmd.ExecuteNonQuery());
        //    if (res > 0)
        //    {
        //        Response.Write("<script>alert('修改成功！');</script>");
        //    }
        //    else
        //    {
        //        Response.Write("<script>alert('修改失败！');</script>");
        //    }
        //    GV2.EditIndex = -1;
        //    Bind();

        //}

        protected void GV2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GV2.EditIndex = -1;
            Bind();
        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            // INSERT INTO Persons VALUES ('Gates', 'Bill', 'Xuanwumen 10', 'Beijing')
            Response.Redirect("~/add_pru.aspx?id=1");
            //string sql = string.Format("insert into user_pru values('" + );
        }

        protected void bt2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/user_update.aspx?id="+id);

        }

        protected void back_shop_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HappyShop.aspx?id=1");
        }

        protected void GV2_RowUpdated(object sender, GridViewUpdatedEventArgs e)
        {

        }

        protected void GV2_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            Response.Write("11111111111");
            Response.Write(e.CommandName);
            if (e.CommandName == "Update")
            {
                //string cell0 = ((TextBox)(GV2.Rows[0].Cells[0].Controls[0]).FindControl("pronum")).Text.Trim().ToString();
                string cell1 = ((TextBox)(GV2.Rows[1].Cells[1].Controls[0]).FindControl("name")).Text.Trim().ToString();
                string cell2 = ((TextBox)(GV2.Rows[2].Cells[2].Controls[0]).FindControl("price")).Text.Trim().ToString();
                string cell3 = ((TextBox)(GV2.Rows[3].Cells[3].Controls[0]).FindControl("num")).Text.Trim().ToString();
                string cell4 = ((TextBox)(GV2.Rows[4].Cells[4].Controls[0]).FindControl("kinds")).Text.Trim().ToString();
                Response.Write(cell1);
                Response.Write(cell2);
                Response.Write(Convert.ToInt32( cell3));
                Response.Write(cell4);
                int index = Convert.ToInt32(e.CommandArgument);// CommandArgument:获取命令的参数
                GridViewRow row = GV2.Rows[index];//获取所选行
                string id1 = row.Cells[0].Text.ToString();//获取第一列
                if (id1 == "")
                    Response.Write("333333333");
                Response.Write(id1);
                //Response.Redirect("~/update_product.aspx?pro_num=" + id1);
            }
        }

        protected void GV2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

 

        protected void GV2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
       
        }
    }
}