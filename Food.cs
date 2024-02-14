using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AssessmentShop
{
    public class Food
    {
        // Attributes
        private string nameOfFood;
        private string sizeOfDish;
        private int noOfCalories;
        private string pictureOfFood;


        // Constructor (0 input parameters)
        public Food()
        {
            nameOfFood = "";
            sizeOfDish = "";
            noOfCalories = 0;
            pictureOfFood = "";
        }

        // Contructors (4 input parameters)
        public Food(string nameIn, string sizeIn, int caloriesIn, string pictureIn)
        {
            nameOfFood = nameIn;
            noOfCalories = caloriesIn;
            pictureOfFood = pictureIn;
            sizeOfDish = sizeIn;
        }


        // Setter Methods
        public void setName(string nameIn)
        {
            nameOfFood = nameIn;
        }

        public void setCalories(int caloriesIn) 
        {
            noOfCalories = caloriesIn;
        }

        public void setSize(string sizeIn)
        {
            sizeOfDish = sizeIn;
        }

        public void setPicture(string pictureIn)
        {
            pictureOfFood = pictureIn;
        }


        // Getter Methods
        public string getNameOfFood()
        {
            return nameOfFood; 
        }

        public int getCalories()
        {
            return noOfCalories;
        }

        public string getSize()
        {
            return sizeOfDish;
        }

        public string getPicture()
        {
            return pictureOfFood;
        }


    }
}