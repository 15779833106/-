using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingWebsite_ASP_NET
{
    public partial class Test : System.Web.UI.Page
    {
        static public String SqlStr = "Server=(local);User Id = sa;Pwd = qweasdzxc;DataBase=db_ShoppingWebsite";
        static public SqlConnection sqlcon = new SqlConnection(SqlStr);
        static public SqlCommand sqlcmd = new SqlCommand();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.Data_Binding();
            }
        }

        //protected void Button2_Click(object sender, EventArgs e)
        //{
        //    String imageName = this.TextBox1.Text;
        //    String fileExtension = System.IO.Path.GetExtension(this.FileUpload1.FileName).ToString();
        //    this.FileUpload1.SaveAs(Server.MapPath("~/Images/") + imageName + ".jpg");
        //    if (fileExtension == ".gif" || fileExtension == ".jpg" || fileExtension == ".bmp" || fileExtension == ".png")
        //    {
        //        this.Image1.ImageUrl = "~/Images/" + this.TextBox1.Text + ".jpg";
        //    }
        //}
        //public bool IsImage(string filePath)
        //{
        //    System.Drawing.Image img;
        //    try
        //    {
        //        img = System.Drawing.Image.FromFile(filePath);
        //        img.Dispose();
        //        return true;
        //    }
        //    catch
        //    {
        //        return false;
        //    }
        //}
        private void Data_Binding()
        {
            if (sqlcon.State == ConnectionState.Closed)
            {
                sqlcon.Open();
            }
            sqlcmd.CommandText = "select top 15 * from all_product";
            sqlcmd.Connection = sqlcon;
            SqlDataReader sqldr = sqlcmd.ExecuteReader();
            List<FileInfo> lfi = new List<FileInfo>();
            while (sqldr.Read() && lfi.Count<12)
            {
                string url = sqldr["product_img_url"]+".jpg";
                //this.TextBox1.Text += url+'\n';
                lfi.Add(new FileInfo(url));
            }
            sqldr.Close();
            sqlcon.Close();
            this.DataListProductList.DataSource = lfi;
            this.DataListProductList.DataBind();
            this.TextBox1.Text += lfi.Count().ToString();
        }
        public void DataListProductList_ItemBound(object sender, DataListItemEventArgs e)
        {
            Image img = (Image)e.Item.FindControl("ImageButton1");
            FileInfo filerow = (FileInfo)e.Item.DataItem;
            //this.TextBox1.Text += filerow.Name + '\n';
            img.ImageUrl = "~/Images/" + filerow.Name;
            return;
        }
        [System.Web.Services.WebMethodAttribute()]
        [System.Web.Script.Services.ScriptMethodAttribute()]
        public static AjaxControlToolkit.Slide[] GetSlides()
        {
            return new AjaxControlToolkit.Slide[] {
                new AjaxControlToolkit.Slide("Images/roll_img/1.jpg","1","vivo X60"),
                new AjaxControlToolkit.Slide("Images/roll_img/2.jpg","2","Huawei Mate X2"),
                new AjaxControlToolkit.Slide("Images/roll_img/3.jpg","3","3"),
                new AjaxControlToolkit.Slide("Images/roll_img/4.jpg","4","4")
            };
        }
    }
}