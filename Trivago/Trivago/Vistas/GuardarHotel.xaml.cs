using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivago.Modelo;
using Trivago.Vistas;
using Trivago.VistasModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trivago.Vista
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GuardarHotel : ContentPage
	{
		public GuardarHotel ()
		{
			InitializeComponent ();
		}

        private void btnGuardar_Clicked(object sender, EventArgs e)
        {
			guardarHotel();
        }

		private void OnNextButtonClicked(object sender, EventArgs e)
		{
			Navigation.PushAsync(new Reservacion_form());

        }


        private async Task guardarHotel()
		{
			MHotel mHotel = new MHotel();
			MVHotel metodo = new MVHotel();

			mHotel.Nombre = nombre.Text;
			mHotel.Contacto = contacto.Text;
			mHotel.Direccion = direccion.Text;

			await metodo.InsertarHotel(mHotel);
			await DisplayAlert("alerta", "Hotel guardado con exito", "OK");
		}

    }
}