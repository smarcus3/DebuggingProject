using RecipeDatabaseXamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RecipeDatabaseXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class testPage : ContentPage
    {
        public testPage()
        {
            InitializeComponent();

            //BINDING
            BindingContext = new testPageViewModel();
        }

        //protected override void OnAppearing()
        //{
        //    BindingContext = new testPageViewModel();

        //    base.OnAppearing();
        //}
    }
}