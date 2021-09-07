using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using temperatura.entidades;

namespace temperatura.negocio
{
    class ClsLogica
    {
        Clsdatos datos = new Clsdatos();
        public string temperatura()
        {   
            int datoA = 2;
            while (datoA == 2)
            {
                Console.WriteLine("querido usuario ingrese la temperatura actual en centigrados\n");
                datos.Tp = int.Parse(Console.ReadLine());

                if (datos.Tp <= 10)
                {
                    Console.WriteLine("el clima es frio");
                    Console.WriteLine("precione\n1 para cerrar el programa\n2 para continuar\n");
                    datoA = int.Parse(Console.ReadLine());
                }

                if (datos.Tp >10 && datos.Tp <= 20)
                {
                    Console.WriteLine("el clima es nublado");
                    Console.WriteLine("precione\n1 para cerrar el programa\n2 para continuar\n");
                    datoA = int.Parse(Console.ReadLine());
                }

                if (datos.Tp > 20 && datos.Tp <= 30)
                {
                    Console.WriteLine("el clima es caluroso");
                    Console.WriteLine("precione\n1 para cerrar el programa\n2 para continuar\n");
                    datoA = int.Parse(Console.ReadLine());
                }

                if (datos.Tp >30)
                {
                    Console.WriteLine("el clima es tropical");
                    Console.WriteLine("precione\n1 para cerrar el programa\n2 para continuar\n");
                    datoA = int.Parse(Console.ReadLine());
                }
                

            }
            return "";
        }
        
    }
}
