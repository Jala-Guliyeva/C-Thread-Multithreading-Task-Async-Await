using System;
using System.Threading;
using System.Threading.Tasks;

namespace Yeniderstest
{
    internal class Program
    {
        public int Count { get; set; }
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(Thread1);
            Thread thread2 = new Thread(Thread2);

            thread1.Start();
            thread2.Start();
            Console.WriteLine("Hello World");
            thread1.Join();
            thread2.Join();
            //Method();
            static void Thread1()
            {
                for (int i = 1; i < 125; i++)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine($"Loop1 {i}");
                }
            }
            static void Thread2()
            {
                for (int i = 125; i < 300; i++)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine($"Loop2 {i}");
                }

            }
            static async Task Method()
            {
                await Task.Run(() =>
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        Console.WriteLine(" Task example");

                        Task.Delay(1000).Wait();
                    }
                });
            }
        }
    }
}
