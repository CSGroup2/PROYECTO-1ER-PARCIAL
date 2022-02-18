using Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Datos {
    public class Datos_Login {

        Conexion conn = new Conexion ();

        public Usuario_Cache LoginUser (String usuario, String contraseña) {
            bool var = false;
            SqlConnection c1 = conn.abrir_conexion ();
            //List<Object> lstClien = new List<Object> ();
            Usuario_Cache usuarioCache = new Usuario_Cache ();
            string sentencia = "select * from (select 'Gerente' as tipo, ge.ID_GERENTE as id_tipo, pers.NOMBRE_1 as nombre, pers.APELLIDO_1 as apellido, " +
                "us.USUARIO, us.CORREO, us.CONTRASENIA " +
                "from GERENTE as ge inner join PERSONA as pers " +
                "on pers.ID_PERSONA = ge.ID_PERSONA " +
                "inner join USUARIO as us " +
                "on us.ID_USUARIO = ge.ID_USUARIO " +
                "UNION " +
                "select 'Cliente', cl.ID_CLIENTE,  pers.NOMBRE_1, pers.APELLIDO_1, us.USUARIO, us.CORREO, us.CONTRASENIA from CLIENTE as cl " +
                "inner join PERSONA as pers " +
                "on pers.ID_PERSONA = cl.ID_PERSONA " +
                "inner join USUARIO as us " +
                "on us.ID_USUARIO = cl.ID_USUARIO) as resul " +
                "where resul.USUARIO = @usuario and resul.CONTRASENIA = @contraseña ";

            SqlCommand comando = new SqlCommand (sentencia, c1); //Para ejecutar 
            comando.Parameters.AddWithValue ("@usuario", usuario);
            comando.Parameters.AddWithValue ("@contraseña", contraseña);
            SqlDataReader registros = comando.ExecuteReader ();
            if (registros.HasRows) {
                while (registros.Read ()) {
                    
                    usuarioCache.Id_tipo = Int16.Parse (registros["id_tipo"].ToString ());
                    usuarioCache.Tipo = registros["tipo"].ToString ();
                    usuarioCache.Nombres = registros["nombre"].ToString ();
                    usuarioCache.Apellidos = registros["apellido"].ToString ();
                }
                //var = true;
            } else {
                //var = false;
                usuarioCache = null;
            }
            conn.cerrar_conexion (c1);
            return usuarioCache;
        }

        public string RecuperarPassword (string userrequesting) {
            SqlConnection c1 = conn.abrir_conexion ();
            string sentencia = "select * from USUARIO where usuario=@usuario or correo=@correo";
            SqlCommand comando = new SqlCommand (sentencia, c1); //Para ejecutar 
            comando.Parameters.AddWithValue ("@usuario", userrequesting);
            comando.Parameters.AddWithValue ("@correo", userrequesting);
            SqlDataReader registros = comando.ExecuteReader ();
            if (registros.Read () == true) {
                string username = registros.GetString (1);
                string usercorreo = registros.GetString (2);
                string contrasenia = registros.GetString (3);

                var serviciocorreo = new Datos_Email_Sistema ();
                serviciocorreo.EnviarCorreo (
                    asunto: "SYSTEM: Solicitud de recuperación de contraseña",
                    cuerpo: "Hola, " + username + " parece que haz tenido un inconveniente al iniciar sesion. \n" +
                    "Haz solicitado recuperar tu contraseña. \n" +
                    "Tú contraseña es: " + contrasenia +
                    "\n Te recomendamos que cambies tu contraseña de inmediato una vez que entre al sistema.",
                    receptor: new List<string> { usercorreo }
                    );
                return "Hola, " + username + " Haz solicitado recuperar tu contraseña. \n" +
                    "Por favor resiva tu bandeja de correo electrónico. \n" +
                    "Y no olvides cambiar tu contraseña una vez dentro del sistema.";
            } else {
                return "Lo sentimos, no existe una cuenta asociada a este usuario o correo electronico";
            }

        }
    }
}
