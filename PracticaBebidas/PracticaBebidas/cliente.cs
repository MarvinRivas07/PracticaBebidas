using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticaBebidas
{
    internal class cliente
    {
        public string Nombre;
        public string Apellido;
        public int edad;


        public void Comprar()
        {
            try
            {
                Console.WriteLine("Muy buenos dias un gusto atenderle:");
                Console.WriteLine("Su nombre por favor caballero/señorita.");
                Console.WriteLine("Por favor ingrese su nombre");
                Nombre = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su apellido");
                Apellido = Console.ReadLine();
                Console.WriteLine("Por favor ingrese su edad");
                edad = int.Parse(Console.ReadLine());
                Console.WriteLine("Mi nombre es Marvin Rivas, sere su mesero en este dia ");


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error", ex.Message);
            }
        }
        public string verCliente()
        {
            return "Nombre del cliente:" + Nombre + " " + "edad:" + edad + " " + "Empleado que lo atendio: Marvin Rivas";
            
        }
    }
}
