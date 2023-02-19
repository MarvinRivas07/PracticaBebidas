using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaBebidas
{
    internal class Program:categoriaBebidas
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bienvenidos \n");
            Console.WriteLine("Opciones\n1-Pedir una bebida  \n2-Salir");
            int opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Bienvenido a El Chaparral");
                    cliente clientee = new cliente();
                    clientee.Comprar();
                    categoriaBebidas cate = new categoriaBebidas();
                    cate.tipoBebida();

                    Console.WriteLine(clientee.verCliente());
                    
                   
                    
                    
                    break;
                default:
                    Console.WriteLine("Lo siento");
                    break;
            }
        }
    }

}
