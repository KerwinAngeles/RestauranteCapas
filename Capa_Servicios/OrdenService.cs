
using Capa_Entidades;
using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Capa_Servicios
{
    public class OrdenService
    {
        Datos_Clientes DatosClientes = new Datos_Clientes();
        public void getOrden(Cliente cliente)
        {
            DatosClientes.TomarOrdernCliente(cliente);
        }
    }
}
