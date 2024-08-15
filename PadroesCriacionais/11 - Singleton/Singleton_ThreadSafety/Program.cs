using System;
using System.Threading.Tasks;
using static System.Console;

namespace Singleton_ThreadSafety
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                () => AcessoThread1(),
                () => AcessoThread2()
            );
            
            ReadLine();
        }

        private static void AcessoThread1()
        {
            Singleton s1 = Singleton.Instance;
            WriteLine("Thread 1 ");
        }
        
        private static void AcessoThread2()
        {
            Singleton s2 = Singleton.Instance;
            WriteLine("Thread 2 ");
        }
    }
}
