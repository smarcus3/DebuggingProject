using LibraryRecipeDatabase;
using RecipeDatabaseXamarin.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace RecipeDatabaseXamarin.ViewModels
{
    public class testPageViewModel : BaseViewModel
    {

        //clRecipeIngredient[] _downloadedRecipeIngredients;
        //public clRecipeIngredient[] downloadedRecipeIngredients

        ObservableCollection<clRecipeIngredient> _downloadedRecipeIngredients = new ObservableCollection<clRecipeIngredient>();
        public ObservableCollection<clRecipeIngredient> downloadedRecipeIngredients
        { 
            get { 
                return _downloadedRecipeIngredients; 
            } 
            set 
            {
                if (downloadedRecipeIngredients != value)
                {
                    _downloadedRecipeIngredients = value;
                    OnPropertyChanged("downloadedRecipeIngredients");
                }
                else
                {
                    int i = 0;
                }
            } 
        }

        //Lists for Pickers
        ObservableCollection<string> _listIngredients = new ObservableCollection<string>();
        public ObservableCollection<string> listIngredients { get { return _listIngredients; } }


        //private clRecipeDataBase recipeDataBase;

        public testPageViewModel()
        {
            //recipeDataBase = new clRecipeDataBase();

            btnPress = new Command<clRecipeIngredient>(madeIt);

            getData();
        }

        async void getData()
        {
            //PICKER INGREDIENT DATA
            //clIngredient[] arrayIngredients = await recipeDataBase.getIngredientData();

            //clIngredient[] arrayIngredients = new clIngredient[5];

            //arrayIngredients[0].IngredientName = "Apple";
            //arrayIngredients[1].IngredientName = "Salt";
            //arrayIngredients[2].IngredientName = "Buuter";
            //arrayIngredients[3].IngredientName = "Flour";
            //arrayIngredients[4].IngredientName = "Egg";

            _listIngredients.Add("Apple");
            _listIngredients.Add("Salt");
            _listIngredients.Add("Butter");
            _listIngredients.Add("Flour");
            _listIngredients.Add("Egg");

            //for (int i = 0; i < arrayIngredients.Length; i++)
            //{
            //    _listIngredients.Add(arrayIngredients[i].IngredientName);
            //}

            //clRecipeIngredient[] arryRecipeIngredients = await recipeDataBase.getRecipeIngredientsDataByRecipeID(310); //HARDCODED TO CRISPY PIZZA RECIPE

            clRecipeIngredient ing = new clRecipeIngredient();
            clRecipeIngredient[] arryRecipeIngredients = new clRecipeIngredient[2];
            ing.IngredientName = "Salt";
            ing.Quantity = 1;
            ing.UnitName = "Cups";
            ing.Comments = "Comments0";
            arryRecipeIngredients[0] = ing;

            clRecipeIngredient ing2 = new clRecipeIngredient();
            ing2.IngredientName = "Apple";
            ing2.Quantity = 2;
            ing2.UnitName = "Whole";
            ing2.Comments = "Comments1";
            arryRecipeIngredients[1] = ing2;


            _downloadedRecipeIngredients.Clear();
            for (int i = 0;i < arryRecipeIngredients.Length;i++)
            {
                
                _downloadedRecipeIngredients.Add(arryRecipeIngredients[i]);
                OnPropertyChanged("downloadedRecipeIngredients");
                OnPropertyChanged("IngredientName");
            }
           
            OnPropertyChanged("downloadedRecipeIngredients");
            OnPropertyChanged("IngredientName");
        }

        public ICommand btnPress { get; private set; }
        void madeIt(clRecipeIngredient x)
        {
            Console.WriteLine(x.IngredientName + " -- " + x.Comments);

            //_downloadedRecipeIngredients.Remove(x);

        }



    }
}
