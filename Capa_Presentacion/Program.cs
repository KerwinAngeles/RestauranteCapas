using Capa_Datos;
using Capa_Servicios;
using System;

namespace Capa_Entidades
{
    class Program
    {
        static OrdenService ordenService = new OrdenService();
        public static void Main(string[] args)
        {
            string nombre = " ";
            string apellidos = " ";
            string orden = " ";
            DateTime fecha;
            
            bool logico = true;

            do
            {
                Console.WriteLine("MENU RESTAURANTE KER");
                Console.WriteLine(" \n 1:Burger \n 2: Tacos \n 3: Pizza \n 4: Salir" );
                int opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Ingrese su nombre");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese su apellido");
                        apellidos = Console.ReadLine();

                        Console.WriteLine("Ingrese la orden de la Hamburguesa");
                        orden = Console.ReadLine();
                        Cliente cliente = new Cliente(nombre, apellidos, orden);
                        ordenService.getOrden(cliente);
                        Console.WriteLine("Orden agregada");
                    break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Ingrese su nombre");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese su apellido");
                        apellidos = Console.ReadLine();

                        Console.WriteLine("Ingrese la orden de los Tacos");
                        orden = Console.ReadLine();

                        Cliente clienteTacos = new Cliente(nombre, apellidos, orden);
                        ordenService.getOrden(clienteTacos);
                        Console.WriteLine("Orden agregada");

                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingrese su nombre");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese su apellido");
                        apellidos = Console.ReadLine();

                        Console.WriteLine("Ingrese la orden de las Pizza");
                        orden = Console.ReadLine();

                        Cliente clientePizza = new Cliente(nombre, apellidos, orden);
                        ordenService.getOrden(clientePizza);
                        Console.WriteLine("Orden agregada");
                        break;
                    case 4:
                        logico = false;
                        break; 
                }   
            }
            while (logico);
        }

    }
}
