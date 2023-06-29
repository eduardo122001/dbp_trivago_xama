using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trivago.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Reservacion_form : ContentPage
    {
        private string hotel = string.Empty;
        public Reservacion_form()
        {
            InitializeComponent();
        }

        private void btn_next_Clicked(object sender, EventArgs e)
        {
            string nombre = nombres.Text;
            string apellido = apellidos.Text;
            DateTime fecha_entrada = dateentrada.Date;
            DateTime fecha_salida = datesalida.Date;
            string adulto = adultos.Text;
            string niño = niños.Text;
            string clase = string.Empty;
            if (Economica.IsChecked)
            {
                clase = "Economica";
            }
            else if (Empresarial.IsChecked)
            {
                clase = "Empresarial";
            }
            else if (suite.IsChecked)
            {
                clase = "Suite";
            }
            else if (presidencial.IsChecked)
            {
                clase = "Presidencial";
            }

            string habitacion = habitaciones.Text;

            Navigation.PushAsync(new Metodo_Pago(nombre, apellido, fecha_entrada, fecha_salida, adulto, niño, clase, habitacion, hotel));
        }

        private void select_nac_SelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            hotel = (string)picker.SelectedItem;
        }
    }
}