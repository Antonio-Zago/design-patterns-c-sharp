using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.Teste
{
    internal class VendaCelta : Factory
    {
        public override ICar Criar()
        {
            return new Celta();
        }
    }
}
