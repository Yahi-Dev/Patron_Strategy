using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstrategy
{
    class EHusky : IEstrategia
    {
        public void CalcularTime()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            int tiempo;
            Console.WriteLine("$$$ COSTO PASEO DE HUSKY SIBERIANO: 60 MNTS");
            tiempo = 5 * 60;
            Console.WriteLine("COSTO: $" + tiempo);
        }
    }
}
