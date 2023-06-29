using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trivago.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class botonView : ContentPage
    {
        public botonView()
        {
            InitializeComponent();
        }
        private async void iniciarSesion_Clicked(object sender, EventArgs e)
        {
            //await Application.Current.MainPage.Navigation.PushModalAsync(new iniciarsesionView());
            await Navigation.PushAsync(new iniciarsesionView());
        }

        private async void registrar_Clicked(object sender, EventArgs e)
        {
            //await Application.Current.MainPage.Navigation.PushModalAsync(new registrarseView());
           await Navigation.PushAsync(new registrarseView());
        }
    }
}