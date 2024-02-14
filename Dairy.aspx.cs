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
    public partial class Page2 : System.Web.UI.Page
    {
        private List<Food> dairyList = new List<Food>();
        protected void Page_Load(object sender, EventArgs e)
        {

            // Declare variables from custom class
            Food semiMilk = new Food("Semi-Skimmed Milk", "1 large sack", 1, "picture1");
            Food cheese = new Food("Chèvre Cheese", "1 ship load", 2, "picture2");
            Food yogurt = new Food("Lamb", "4 long tons", 3, "picture3");
            Food donkeyMilk = new Food("Donkey Milk", "A handfull", 4, "picture4");

            // add the individual products into the grouping list
            dairyList.Add(semiMilk);
            dairyList.Add(cheese);
            dairyList.Add(yogurt);
            dairyList.Add(donkeyMilk);

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