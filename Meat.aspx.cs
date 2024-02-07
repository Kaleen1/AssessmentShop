using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Template_Project
{   
    public partial class Page1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void LnkBtnMeats_Click(object sender, EventArgs e)
        {
            Response.Redirect("Meat.aspx");
        }

        protected void LnkBtnDairy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Dairy.aspx");
        }

        protected void LnkBtnVeg_Click(object sender, EventArgs e)
        {
            Response.Redirect("Vegetables.aspx");
        }

        protected void LnkBtnSweet_Click(object sender, EventArgs e)
        {
            Response.Redirect("Sweets.aspx");
        }

        protected void LnkBtnContact_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContactUs.aspx");
        }
    }
}