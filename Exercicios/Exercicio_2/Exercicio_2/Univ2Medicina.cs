using System.Collections.Generic;

namespace Exercicio_2
{
    class Univ2Medicina : IAluno
    {
        public List<string> Cursos()
        {
            return new List<string> { "Fisiologia", "Anatomia", "Histologia" };
        }
    }
}
