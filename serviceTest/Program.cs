using System.Threading;

namespace Cron
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($@"Cron - Registro de execução em {DateTime.Now.ToString()}");

            Thread.Sleep(2000);
        }
    }
}