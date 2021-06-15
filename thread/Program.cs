using System;
using System.Threading;
using System.Threading.Tasks;

namespace thread
{
    class Program
    {
        static void Main(string[] args)
        {
            Transacoes transacoes = new Transacoes();

            Thread[] threads = new Thread[12];

            for (int i = 0; i < threads.Length; i++)
            {
                Thread thread = new Thread(transacoes.Saque);
                thread.Name = $"Thread {i}";
                threads[i] = thread;
            }

            foreach (var item in threads)
            {
                item.Start();
            }

            Console.Read();
        }

    }
}
