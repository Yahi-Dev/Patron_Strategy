using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstrategy
{
    class EChihuahua : IEstrategia
    {
        public void CalcularTime()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            int tiempo;
            Console.WriteLine("$$$ COSTO POR PASEO AL CHIHUAHUA: 20 MNTS ");
            tiempo = 5 * 20;
            Console.WriteLine("COSTO: $" + tiempo);
        }
    }
}
