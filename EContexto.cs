using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstrategy
{
    class EContexto
    {
        IEstrategia estrategia;

        public EContexto(IEstrategia objeto)
        {
            this.estrategia = objeto;
        }

        public void Ejecutar()
        {
            estrategia.CalcularTime();
        }
    }
}
