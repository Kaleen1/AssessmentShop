using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssessmentShop
{
    public class Food
    {
        // Attributes
        private string name, genre, picture;
        private int price;

        // Getter Methods
        public string getName()
        {
            return name; 
        }

        public int getPrice()
        {
            return price;
        }

        public string getGenre()
        {
            return genre;
        }

        public string getPicture()
        {
            return picture;
        }


    }
}