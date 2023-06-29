using HotellWhiteIsaac.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;

namespace Trivago.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Mostrar_reserva : ContentPage
    {
        string nombred;
        string apellidod;
        DateTime fecha_entradad;
        DateTime fecha_salidad;
        string adultod;
        string niñod;
        string clased;
        string habitaciond;
        string hoteld;

        public Mostrar_reserva(string nombre, string apellido, DateTime fecha_entrada, DateTime fecha_salida, string adulto, string niño, string clase, string habitacion, string hotel,
            string tipo_tarjeta, string tarjeta_credito, string meses, string años, string codigo, string paises, string ciudades, string direcciones)
        {
            InitializeComponent();

            string fe = fecha_entrada.ToString("dd/MM/yy");
            string fs = fecha_salida.ToString("dd/MM/yy");

            rnombre.Text = nombre + " " + apellido;
            rhotel.Text = hotel;
            rfecha.Text = "Del " + fe + " al " + fs;
            radulto.Text = adulto;
            rniño.Text = niño;
            rclase.Text = clase;
            rhabitacion.Text = habitacion;
            rtarjeta.Text = tipo_tarjeta + ": **** **** **** " + tarjeta_credito.Substring(tarjeta_credito.Length - 4);
            rpais.Text = paises;
            rciudad.Text = ciudades;
            rdireccion.Text = direcciones;
        }

        private void btn_next_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new ProfilePage());
        }


    }
}