using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstrategy
{
    class ELabrador : IEstrategia
    {
        public void CalcularTime()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            int tiempo;
            Console.WriteLine("$$$ COSTO DE PASEO LABRADOR: 40 MNTS");
            tiempo = 5 * 40;
            Console.WriteLine("COSTO: $" + tiempo);
        }
    }
}
