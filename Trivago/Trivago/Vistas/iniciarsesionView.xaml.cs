using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using HotellWhiteIsaac.Views;
using Trivago.Vista;
using Trivago.Vistas;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trivago.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class iniciarsesionView : ContentPage
    {
        private string correo;
        private string contraseña;
        public iniciarsesionView()
        {
            InitializeComponent();
            
        }

        private async void  iniregresar_Clicked(object sender, EventArgs e)
        {
            // await Application.Current.MainPage.Navigation.PopModalAsync();
            await Navigation.PushAsync(new botonView());
        }

        private void btns_guardar_Clicked(object sender, EventArgs e)
        {
            /* string correoo = x1_correo.Text;
             string contraseñaa = x1_contraseña.Text;

             if (correoo == correo && contraseñaa == contraseña)
             {
                 DisplayAlert("Estado", "Los datos ingresados son correctos", "Aceptar");
             }
             else
             {
                 DisplayAlert("Estado", "Los datos ingresados son incorrectos", "Aceptar");
             }
            */
            Navigation.PushAsync(new ProfilePage());
           // await Application.Current.MainPage.Navigation.PushModalAsync(new GuardarHotel());
        }
    }
}