using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioEstrategy
{
    internal class Fabrica
    {
        public static IEstrategia GetEstrategia(string name)
        {
            switch (name) 
            {
                case "c": return new EChihuahua();
                case "l": return new ELabrador();
                case "h": return new EHusky();

                default: return new EError();
            }
            

        }
    }
}
