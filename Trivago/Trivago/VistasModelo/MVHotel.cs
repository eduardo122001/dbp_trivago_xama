using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Trivago.Modelo;
using Trivago.Servicios;

namespace Trivago.VistasModelo
{
    public class MVHotel
    {
        List<MHotel> hotelData = new List<MHotel> ();
        string Idusuario;
        
        public async Task<List<MHotel>> Mostrar_Hotel()
        {
            var hotel = await Conexionfirebase.firebase
                .Child("Hotel")
                .OnceAsync<MHotel>();

            foreach (var hoteld in hotel)
            {
                MHotel mHotel= new MHotel();
                mHotel.Nombre = hoteld.Object.Nombre;
                mHotel.Contacto = hoteld.Object.Contacto;
                mHotel.Direccion = hoteld.Object.Direccion;

                hotelData.Add(mHotel);
            }
            return hotelData;
        }

        public async Task<string> InsertarHotel(MHotel parametro)
        {
            var data = await Conexionfirebase.firebase
                .Child("Hotel")
                .PostAsync(new MHotel()
                {
                    Nombre = parametro.Nombre,
                    Contacto = parametro.Contacto,
                    Direccion = parametro.Direccion
                });
            Idusuario = data.Key;
            return Idusuario;
        }
    }
}
