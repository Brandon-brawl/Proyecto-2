using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dame_un_sonrisa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ropa miRopa;
            //miRopa = new Ropa( "Azul", "generica");
            //miRopa.Marca = "Cuidado con el perro";
            //Console.WriteLine(miRopa.ToString());

            Camisa miCamisa;
            miCamisa = new Camisa();
            miCamisa.Color = "Azul, ";
            miCamisa.Marca = "Cuidado con el perro, ";
            miCamisa.Talla = "chica, ";
            Console.WriteLine(miCamisa.ToString());
            Console.ReadKey();
        }
    }
}
