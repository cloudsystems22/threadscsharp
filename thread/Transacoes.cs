using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread
{
    public class Transacoes
    {
        private int saldo = 1000;

        Object locker = new Object();

        Random random = new Random();


        public void Saque()
        {
            lock (locker)
            {
                if (saldo > 0)
                {
                    Console.WriteLine("Thread: {0}", Thread.CurrentThread.Name);
                    Console.WriteLine("Saldo R$ {0}", saldo);
                    saldo -= 100;
                    Thread.Sleep(random.Next(1, 10) * 100);
                    Console.WriteLine("Novo saldo R$ {0}", saldo);

                }
                else
                {
                    Console.WriteLine("Não há saldo suficiente");
                } 
            }
        }
    }
}
