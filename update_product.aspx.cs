using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ShoppingWebsite_ASP_NET
{
    public partial class update_product : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            string pro_num = Request.QueryString["pro_num"];
            Response.Write(pro_num);
        }
    }
}