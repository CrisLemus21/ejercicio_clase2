using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using temperatura.negocio;

namespace temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            ClsLogica logica = new ClsLogica();
            Console.WriteLine(logica.temperatura());
            Console.ReadLine();

        }
    }
}
