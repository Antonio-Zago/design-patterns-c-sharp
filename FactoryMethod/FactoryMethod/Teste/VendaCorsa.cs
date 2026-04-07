using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Teste
{
    internal class VendaCorsa : Factory
    {
        public override ICar Criar()
        {
            return new Corsa();
        }
    }
}
