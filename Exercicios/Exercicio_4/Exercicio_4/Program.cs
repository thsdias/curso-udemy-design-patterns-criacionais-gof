using System;

namespace Exercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            CriadorLanche builder;

            // Inicia a criaca. 
            Cozinha cozinha = new Cozinha();

            // Cria e exibe os lanches.
            builder = new LancheNatural();
            cozinha.MontaLanche(builder);
            builder.Lanche.Exibir();

            builder = new LancheNormal();
            cozinha.MontaLanche(builder);
            builder.Lanche.Exibir();

            Console.ReadLine();
        }
    }
}
