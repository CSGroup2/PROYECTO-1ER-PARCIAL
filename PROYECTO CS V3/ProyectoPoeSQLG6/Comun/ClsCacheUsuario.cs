using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun
{
    public static class ClsCacheUsuario
    {

        private static int id_tipo;
        private static string nombres;
        private static string apellidos;
        private static string tipo; 

        public static string Nombres { get => nombres; set => nombres = value; }
        public static string Apellidos { get => apellidos; set => apellidos = value; }
        public static string Tipo { get => tipo; set => tipo = value; }
        public static int Id_tipo { get => id_tipo; set => id_tipo = value; }
    }
}
