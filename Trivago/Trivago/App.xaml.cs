using System;
using trivago.View;
using Trivago.Vista;
using Trivago.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trivago
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new botonView());
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
