using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    internal class Cerveza : BebidaEmbriagante
    {
        public override int cuantomeembriagaPorHora()
        {
            return 5;
        }
    }
}
