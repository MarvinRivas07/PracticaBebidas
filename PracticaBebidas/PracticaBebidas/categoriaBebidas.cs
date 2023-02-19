using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaBebidas
{
    internal class categoriaBebidas:Bebidas
    {
        private string tipo;
        public void tipoBebida()

        {
            Console.WriteLine("Que tipo de bebida desea: \n1-Bebidas Alcoholicas \n2-Bebidas no alcoholicas");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1: tipo = "Bebidas Alcoholicas";
                    Bebidas bebi = new Bebidas();
                    bebi.Bebidass();
                    bebi.seleccionarBebida(bebi.Tipo);
                    break;
                case 2: tipo = "Bebidas no alcoholicas";
                    Bebidas bebis = new Bebidas();  
                    bebis.bebidasNoAlcoholicas();
                    bebis.seleccionarBebidaNoAlcoholica();
                    break ;
                default:
                    break;
            }
        }
      
    }
}
