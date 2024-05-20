using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstrategy
{
    class EError : IEstrategia
    {
        public void CalcularTime()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("ESTA OPCION NO ES VALIDA");
        }
    }
}
