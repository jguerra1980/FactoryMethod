using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class VinoTinto : BebidaEmbriagante
    {
        public override int cuantomeembriagaPorHora()
        {
            return 20;
        }
    }
}
