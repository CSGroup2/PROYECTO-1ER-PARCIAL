using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model {
    public class Usuario_Cache {
        private int id_tipo;
        private string nombres;
        private string apellidos;
        private string tipo;

        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Id_tipo { get => id_tipo; set => id_tipo = value; }
    }
}
