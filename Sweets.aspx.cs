using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AssessmentShop;

namespace Template_Project
{
    public partial class Page4 : System.Web.UI.Page
    {
        private List<Food> sweetsList = new List<Food>();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Declare variables from custom class
            Food u235 = new Food("Uraniam-235", "1 gram", 2000000000, "picture1");
            Food orbeez = new Food("Orbeez", "1 carton", 24, "picture2");
            Food redPlaydough = new Food("Red Playdough", "1 gram", 5, "picture3");
            Food bluePlaydough = new Food("Blue Playdough", "1 bathtub", 1000000, "picture4");

            // add the individual products into the grouping list
            sweetsList.Add(u235);
            sweetsList.Add(orbeez);
            sweetsList.Add(redPlaydough);
            sweetsList.Add(bluePlaydough);

        }

        protected void LnkBtnMeats_Click(object sender, EventArgs e)
        {
            Response.Redirect("Meat.aspx");
        }

        protected void LnkBtnDairy_Click1(object sender, EventArgs e)
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