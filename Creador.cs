using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public  class Creador // Esta clase crea objetos
    {
        public const int VINOTINTO = 1;
        public const int CERVEZA = 2;

        public static BebidaEmbriagante CreadorBebida (int tipo)
        {
            switch (tipo)
            {
                case VINOTINTO:
                    return new VinoTinto();
                 case CERVEZA:
                    return new Cerveza();
                default: return null;
            }


        }

    }
}
