using Firebase.Database.Query;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Trivago.Modelo;
using Trivago.Servicios;

namespace trivago.VistaModelo
{
    public class MVUusuario
    {
        List<MUusuario> usuarioData = new List<MUusuario> () ;
        public async Task<List<MUusuario>> Mostrar_Usuario()
        {
            var usuario = await Conexionfirebase.firebase 
                .Child("registrarse")
                .OnceAsync<MUusuario>();

            foreach(var user in usuario)
            {
                MUusuario mUsuarios = new MUusuario();
                mUsuarios.Id_User = user.Key;
                mUsuarios.nombre = user.Object.nombre;
                mUsuarios.apellido = user.Object.apellido;
                mUsuarios.correo = user.Object.correo;
                mUsuarios.contraseña = user.Object.contraseña;



                usuarioData.Add(mUsuarios);



            }
            return usuarioData;
        }
        public async Task InsertarUsuario(MUusuario parametro)
        {
            await Conexionfirebase.firebase
                 .Child("registrarse")
                 .PutAsync(new MUusuario()
                 {
                     nombre = parametro.nombre,
                     apellido = parametro.apellido,
                     correo = parametro.correo,
                     contraseña = parametro.contraseña
                 });
           
          
        }
    }
}
