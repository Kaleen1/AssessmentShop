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
    public partial class Page3 : System.Web.UI.Page
    {

        private List<Food> vegetablesList = new List<Food>();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Declare variables from custom class
            Food Wasabi = new Food("Wasabi", "20 grams", 200, "picture1");
            Food Artichoke = new Food("Artichokes", "12 kg", 1, "picture2");
            Food Tomatoes = new Food("Tomatoes", "1 barrel", 2000, "picture3");
            Food carrots = new Food("Carrots", "1 thimblefull", 4, "picture4");

            // add the individual products into the grouping list
            vegetablesList.Add(Wasabi);
            vegetablesList.Add(Artichoke);
            vegetablesList.Add(Tomatoes);
            vegetablesList.Add(carrots);

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