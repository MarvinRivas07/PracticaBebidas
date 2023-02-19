using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PracticaBebidas
{
    internal class Bebidas
    {
        private string tipo;

        public string Tipo { get => tipo; set => tipo = value; }

        public void Bebidass()
        {
            
            Console.WriteLine("Este es el menu de bebidas alcoholicas:");
            string [] bebidas = new string[5];
            bebidas[0] = "Jose Cuervo $7.50";
            bebidas[1] = "Tequila $5.25";
            bebidas[2] = "Jarana $12.75";
            bebidas[3] = "Cervezas $2.00";
            bebidas[4] = "Wisky  $3.75";

            for (int i = 0; i < bebidas.Length; i++)
            {
                Console.WriteLine(bebidas[i]);
            }
            
        }
        public void seleccionarBebida(string _Tipo)
        {
            this.Tipo = _Tipo;
            Console.WriteLine("Que tipo de bebida desea: \n1-Jose Cuervo \n2-Tequila \n3-Jarana \n4-Cervezas \n5-Wisky");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Tipo = "Jose Cuervo";
                    break;
                case 2:
                    Tipo = "Tequila";
                    break;
                case 3:
                    Tipo = "Jarana";
                    break;
                case 4:
                    Tipo = "Cervezas";
                    break;
                case 5:
                    Tipo = "Wisky";
                    break;
                default:
                    break;
            }
        }
      
        public void bebidasNoAlcoholicas()
        {
            Console.WriteLine("Este es el menu de bebidas no alcoholicas:");
            string[] bebidas = new string[5];
            bebidas[0] = "Sodas $1.25";
            bebidas[1] = "Jugo de naranja $1.50";
            bebidas[2] = "Licuados $1.00";
            bebidas[3] = "Horchata $1.50";
            bebidas[4] = "Cafe $0.50";

            for (int i = 0; i < bebidas.Length; i++)
            {
                Console.WriteLine(bebidas[i]);
            }
        }
        public void seleccionarBebidaNoAlcoholica()
        {
            Console.WriteLine("Que tipo de bebida desea: \n1-Sodas \n2-Jugo de naranja \n3-Licuados \n4-Horchata \n5-Cafe \n");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Tipo = "Sodas";
                    break;
                case 2:
                    Tipo = "Jugo de naranja";
                    break;
                case 3:
                    Tipo = "Licuados";
                    break;
                case 4:
                    Tipo = "Horchata";
                    break;
                case 5:
                    Tipo = "Cafe";
                    break;
                default:
                    break;
            }
        }


        
    }
}
