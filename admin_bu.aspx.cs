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
    public partial class admin_bu : System.Web.UI.Page
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
            DataList1.DataSource = myds1.Tables["tb1"];
            DataList1.DataBind();
        }

        protected void DataList1_DeleteCommand(object source, DataListCommandEventArgs e)
        {

            string sql = "delete from all_product where product_id=@product_id";
            SqlParameter pms = new SqlParameter("@product_id", e.CommandArgument);
            SqlHelper.ExecuteNonQuery(sql, pms);

            Bind();
        }

        protected void DataList1_UpdateCommand(object source, DataListCommandEventArgs e)
        {
            string ProNum = (e.Item.FindControl("txtNum") as TextBox).Text;
            string ProName = (e.Item.FindControl("name") as TextBox).Text;
            string ProPrice = (e.Item.FindControl("price") as TextBox).Text;
            string ProKinds = (e.Item.FindControl("kinds") as TextBox).Text;

            string sql = "update all_product set product_buy_num=@product_buy_num,product_name=@product_name ,product_price=@product_price ,product_kinds=@product_kinds  where product_id=@product_id";
            SqlParameter[] pms = new SqlParameter[]{
            new SqlParameter("@product_buy_num",ProNum),
              new SqlParameter("@product_name",ProName),
                new SqlParameter("@product_price",ProPrice),
                  new SqlParameter("@product_Kinds",ProKinds),
            new SqlParameter("@product_id",e.CommandArgument)
            };
            SqlHelper.ExecuteNonQuery(sql, pms);
            // Response.Write("<script>alert('更新成功！')</Script>");
            this.DataList1.EditItemIndex = -1;
            Bind();
        }

        protected void DataList1_EditCommand(object source, DataListCommandEventArgs e)
        {
            this.DataList1.EditItemIndex = e.Item.ItemIndex;
            Bind();
        }

        protected void DataList1_CancelCommand(object source, DataListCommandEventArgs e)
        {
            this.DataList1.EditItemIndex = -1;
            Bind();
        }

        protected void bt1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/add_pru.aspx?id=1");
        }

        protected void bt2_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/user_update.aspx?id=" + id);
        }

        protected void back_shop_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/HappyShop.aspx?id=1");
        }
    }
}