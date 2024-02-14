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
    public partial class Page1 : System.Web.UI.Page
    {

        private List<Food> meatList = new List<Food>();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Declare variables from custom class
            Food beef = new Food("Beef", "1 tonne", 3320000, "picture1");
            Food duck = new Food("Duck", "55.7 kg", 187709, "picture2");
            Food lamb = new Food("Lamb", "3 tonnes", 8820000, "picture3");
            Food elephant = new Food("African Elephant", "1 gram", 2, "picture4");

            // add the individual products into the grouping list
            meatList.Add(beef);
            meatList.Add(duck);
            meatList.Add(lamb);
            meatList.Add(elephant);
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