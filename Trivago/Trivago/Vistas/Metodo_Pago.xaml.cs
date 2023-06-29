using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trivago.Modelo;
using Trivago.VistasModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trivago.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Metodo_Pago : ContentPage
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
        public Metodo_Pago(string nombre, string apellido, DateTime fecha_entrada, DateTime fecha_salida, string adulto, string niño, string clase, string habitacion, string hotel)
        {
            InitializeComponent();
            nombred = nombre;
            apellidod = apellido;
            fecha_entradad = fecha_entrada;
            fecha_salidad = fecha_salida;
            adultod = adulto;
            niñod = niño;
            clased = clase;
            habitaciond = habitacion;
            hoteld = hotel;


        }


        private async void btn_next_Clicked(object sender, EventArgs e)
        {
            string tipo_tarjeta = string.Empty;
            if (credito.IsChecked)
            {
                tipo_tarjeta = "Credito";
            }
            else if (debito.IsChecked)
            {
                tipo_tarjeta = "Debito";
            }

            string tarjeta_credito = tarjeta.Text;
            string meses = mes.Text;
            string años = año.Text;
            string codigo = code.Text;
            string paises = pais.Text;
            string ciudades = ciudad.Text;
            string direcciones = direccion.Text;
           await guardar_reserva();
           await Navigation.PushAsync(new Mostrar_reserva(nombred, apellidod, fecha_entradad, fecha_salidad, adultod, niñod, clased, habitaciond, hoteld
                , tipo_tarjeta, tarjeta_credito, meses, años, codigo, paises, ciudades, direcciones));
        }

        private async Task guardar_reserva()
        {
            Mreservas mReservas = new Mreservas();
            MVReserva metodo= new MVReserva();

            string tipo_tarjetad = string.Empty;
            if (credito.IsChecked)
            {
                tipo_tarjetad = "Credito";
            }
            else if (debito.IsChecked)
            {
                tipo_tarjetad = "Debito";
            }

            mReservas.nombre = nombred;
            mReservas.apellido = apellidod;
            mReservas.entrada = fecha_entradad.ToString("dd/MM/yy");
            mReservas.salida = fecha_salidad.ToString("dd/MM/yy");
            mReservas.adultos = adultod;
            mReservas.niños = niñod;
            mReservas.clase=clased;
            mReservas.habitaciones = habitaciond;
            mReservas.hotel= hoteld;
            mReservas.tipo_tarjeta = tipo_tarjetad;
            mReservas.nro_tarjeta = tarjeta.Text;
            mReservas.exp_m = mes.Text;
            mReservas.exp_y = año.Text;
            mReservas.cv = code.Text;
            mReservas.pais = pais.Text;
            mReservas.ciudad = ciudad.Text;
            mReservas.direccion = direccion.Text;

            await metodo.insertar_reserva(mReservas);
            await DisplayAlert("Pago finalizado","Usted ha relizado un pago","Aceptar");
        }

    }
}