using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRecipeDatabase
{
    public class clRecipeIngredient
    {
        public int RecipeIngredientsID { get; set; }
        public int RecipeIDLookedUP { get; set; }
        public int IngredientIDLookedUp { get; set; }
        public double Quantity { get; set; }
        public int UnitIDLookedUp { get; set; }
        public bool HiddenFlag { get; set; }
        public string UnitName { get; set; }
        public string IngredientName { get; set; }
        public string Comments { get; set; }

        //public bool NewlyCreated { get; set; }

        public clRecipeIngredient()
        {
            //NewlyCreated = false;
            HiddenFlag = false;
            IngredientName = "Unknown";
        }
        public override string ToString()
        {
            return IngredientName;
        }

        public string[] returnRowDataGrid()
        {
            string[] rowdata = new string[5];
            rowdata[0] = RecipeIngredientsID.ToString();
            rowdata[1] = IngredientName.ToString();
            rowdata[2] = Quantity.ToString();
            rowdata[3] = UnitName.ToString();
            try
            {
                if(string.IsNullOrEmpty(Comments))
                    rowdata[4] = "";
                else
                    rowdata[4] = Comments.ToString();
            }
            catch
            {
                rowdata[4] = "";
            }
            return rowdata;
        }
    }
}
