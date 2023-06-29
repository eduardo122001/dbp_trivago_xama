using System;
using System.Collections.Generic;
using System.Text;
using Firebase.Database;
namespace Trivago.Servicios
{
    class conexion_firebase1
    {
        public static FirebaseClient firebase = new FirebaseClient("https://trivago-5f76b-default-rtdb.firebaseio.com/");
    }
}
