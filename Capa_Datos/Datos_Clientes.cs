using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos
{
    public class Datos_Clientes
    {
        string ruta = @"C:\\Proyectos\\ArqCapas\\ProyectoRestaurante\\CapasITLA\\Capa_Datos\\Orden.txt";
        public List<Cliente> clientes;

        public Datos_Clientes()
        {
            clientes = new List<Cliente>();
        }
        public  void TomarOrdernCliente(Cliente cliente)
        {
            try
            {
                clientes.Add(cliente);

                using (StreamWriter file = new StreamWriter(ruta, true))
                {
                    foreach (var client in clientes)
                    {
                        string order = $" \n Nombre: {client.Nombre} \n Apellidos {client.Apellidos} \n Orden: {client.Orden} \n Fecha: {client.Fecha}";   
                        file.WriteLine(order);
                    }
                }
            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message);
            }
        }
      
    }
}
