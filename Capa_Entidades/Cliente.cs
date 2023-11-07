using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Orden { get; set;  }
        public DateTime Fecha { get; set; }

        public Cliente(string nombre, string apellidos, string orden) 
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Orden = orden;
            Fecha = DateTime.Now;
        }
    }
}
