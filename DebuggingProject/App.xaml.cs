using RecipeDatabaseXamarin.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DebuggingProject
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new testPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
