using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Trivago.Modelo;
using Trivago.Servicios;
using Firebase.Database.Query;
using Xamarin.Forms.PlatformConfiguration;

namespace Trivago.VistasModelo
{
    internal class MVReserva
    {

        //List<conexion_firebase1> reservas=  new List<conexion_firebase1>();
        //public async Task<List<>> 
        List<Mreservas> reserva_data = new List<Mreservas>();
        string id_reserva;
        public async Task<List<Mreservas>> mostrar_reserva()
        {
            var reserva = await conexion_firebase1.firebase
                .Child("Reservas")
                .OnceAsync<Mreservas>();
            foreach (var reserv in reserva)
            {
                Mreservas mReservas = new Mreservas();
                mReservas.id_user = reserv.Key;
                mReservas.nombre = reserv.Object.nombre;
                mReservas.exp_y = reserv.Object.exp_y;
                mReservas.exp_m = reserv.Object.exp_m;
                mReservas.pais = reserv.Object.pais;
                mReservas.tipo_tarjeta = reserv.Object.tipo_tarjeta;
                mReservas.adultos = reserv.Object.adultos;
                mReservas.ciudad = reserv.Object.ciudad;
                mReservas.salida = reserv.Object.salida;
                mReservas.entrada = reserv.Object.entrada;
                mReservas.clase = reserv.Object.clase;
                mReservas.habitaciones = reserv.Object.habitaciones;
                mReservas.niños = reserv.Object.niños;
                mReservas.cv = reserv.Object.cv;
                mReservas.hotel = reserv.Object.hotel;
                mReservas.nro_tarjeta = reserv.Object.nro_tarjeta;
                mReservas.apellido = reserv.Object.apellido;
                mReservas.direccion = reserv.Object.direccion;

                reserva_data.Add(mReservas);
            }
            return reserva_data;
        }
        public async Task <string>insertar_reserva(Mreservas parametro)
        {
           var data= await conexion_firebase1.firebase
                .Child("Reservas")
                .PostAsync(new Mreservas()
                {
                    nombre = parametro.nombre,

                    exp_y = parametro.exp_y,
                    exp_m = parametro.exp_m,
                    pais = parametro.pais,
                    tipo_tarjeta = parametro.tipo_tarjeta,
                    adultos = parametro.adultos,
                    ciudad = parametro.ciudad,
                    salida = parametro.salida,
                    entrada = parametro.entrada,
                    clase = parametro.clase,
                    habitaciones = parametro.habitaciones,
                    niños = parametro.niños,
                    cv = parametro.cv,
                    hotel = parametro.hotel,
                    nro_tarjeta = parametro.nro_tarjeta,
                    apellido = parametro.apellido,
                    direccion = parametro.direccion
                });
            id_reserva = data.Key;
            return id_reserva;
        }

    }
}
