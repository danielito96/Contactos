using System;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Contactos
{
    public partial class App : Application
    {

        public static MobileServiceClient MobileServiceClient  = new MobileServiceClient("https://danielcontactos.azurewebsites.net");

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public static String RUTA_BD;

        public App(String ruta_bd)
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());

            RUTA_BD = ruta_bd;
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
