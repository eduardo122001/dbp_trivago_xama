using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using trivago.VistaModelo;
using Trivago.Modelo;
using Trivago.Vista;
using Trivago.VistasModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace trivago.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registrarseView : ContentPage
    {
        public registrarseView()
        {
            InitializeComponent();
        }
       
        private async void reregresar_Clicked(object sender, EventArgs e)
        {
            //await Application.Current.MainPage.Navigation.PopModalAsync();
            await Navigation.PushAsync(new botonView());
        }

        private async void btn_guardar_Clicked(object sender, EventArgs e)
        {
            await guardarcontacto();
        }

        private async Task guardarcontacto()
        {
            MUusuario mUusuario= new MUusuario();
            MVUusuario metodo= new MVUusuario();

            

            mUusuario.nombre = x_nombre.Text;
            mUusuario.apellido = x_apellido.Text;
            mUusuario.correo= x_correo.Text;
            mUusuario.contraseña = x_contraseña.Text;

            await metodo.InsertarUsuario(mUusuario);
            await DisplayAlert("cargando", "guardando", "acepta :)");
            await Navigation.PushAsync(new botonView());
            // iniciarsesionView iniciarsesion = new iniciarsesionView(x_correo.Text, x_contraseña.Text);
            //await Application.Current.MainPage.Navigation.PushModalAsync(iniciarsesion);

        }
    }
}