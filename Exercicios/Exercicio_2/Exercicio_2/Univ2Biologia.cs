using System.Collections.Generic;

namespace Exercicio_2
{
    class Univ2Biologia : IAluno
    {
        public List<string> Cursos()
        {
            return new List<string> { "Morfologia", "Taxonomia", "Zoologia dos Invertebrados" };
        }
    }
}
