using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_2
{
    public class Univ1Fisica : IAluno
    {
        public List<string> Cursos()
        {
            return new List<string> { "Física Quântica", "Física Básica", "Física Aplicada" };
        }
    }
}