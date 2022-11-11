using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class FoodMacros
    {
        int example = 0;

        public string FoodName { get; set; }

        public int AmountOfCalories { get; set; }
        public int AmountOfProtein { get; set; }

        public int Example 
        {
            get { return example; }
            set { example = value; }
        }
    }

    /*
    FoodMacros f1 = new FoodMacros
    {
        //set the variable to user input 
        FoodName = textBoxFoodName.Text;
    }
    */

    /*
    public int Get_Value()
    {
        /*
        if (value_textbox.Text == "")
        {
            MessageBox.Show("No input");
        }
        */
        //return 0;
    //}
 
    /*
    string value_txt = value_textbox.Text;
    int value = int.Parse(value_txt);
    return value;

    if (value_textbox.Text == "")
    {
        MessageBox.Show("No input");
        return 0;
    }

    int value = int.Parse(value_textbox.Text);
    return value;
    */
}