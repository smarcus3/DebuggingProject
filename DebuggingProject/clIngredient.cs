
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryRecipeDatabase
{
    public class clIngredient// : BindableBase
    {
        public int IngredientsID { get; set; }
        public string IngredientName { get; set; }
        //public string IngredientNameBindable
        //{
        //    get { return IngredientName; }
        //    set
        //    {
        //        //string prop = IngredientName;
        //        //SetProperty(ref prop, value); }
        //        IngredientName = value;
        //        //RaisePropertyChanged();
        //        PropertyChanged(this, new PropertyChangedEventArgs("IngredientName"));
        //    }
        //}
        //public event PropertyChangedEventHandler PropertyChanged;
        public int AisleIDLookedUp { get; set; }
        public bool HiddenFlag { get; set; }
        public int UnitUsedForWeightCalculationLookedUp { get; set; }
        public double OzPerUnitUsedForWeight { get; set; }
        public string AisleName { get; set; }

        public clIngredient()
        {

        }

        public override string ToString()
        {
            return IngredientName;
        }
    }
}
