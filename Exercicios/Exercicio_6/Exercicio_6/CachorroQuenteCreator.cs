using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_6
{
    public class CachorroQuenteCreator : LancheCreator
    {
        protected override Lanche CriaLanche()
        {
            return new CachorroQuente();
        }
    }
}
