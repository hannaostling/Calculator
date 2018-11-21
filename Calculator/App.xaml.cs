using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Calculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var calculator = new Calculator();
            calculator.BackgroundColor = Color.FromHex("#545457");
            MainPage = calculator;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
