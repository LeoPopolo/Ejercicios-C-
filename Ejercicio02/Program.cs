using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    using Entidad;

    class Program
    {
        static void Main(string[] args)
        {
            Sello.mensaje = "Leo";
            Sello.color = ConsoleColor.Blue;

            Sello.ImprimirEnColor();

            Console.ReadKey();
        }
    }
}
