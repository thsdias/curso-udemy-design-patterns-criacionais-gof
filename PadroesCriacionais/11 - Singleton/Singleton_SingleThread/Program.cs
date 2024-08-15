using System;
using static System.Console;

namespace Singleton_SingleThread
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("##### Padrão Singleton #####\n");
            WriteLine("Tentando criar uma instância s1.");

            Singleton s1 = Singleton.Instance;

            WriteLine("Tentando criar uma instância s2.");

            Singleton s2 = Singleton.Instance;

            if (s1 == s2)
            {
                WriteLine("Existem somente uma instância (s1==s2)");
            }
            else
            {
                WriteLine("Existem instâncias diferentes (s1 e s2)");
            }
            
            Read();
        }
    }
}
