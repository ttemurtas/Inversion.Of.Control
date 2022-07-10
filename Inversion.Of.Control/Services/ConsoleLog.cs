using Inversion.Of.Control.Services.Interfaces;

namespace Inversion.Of.Control.Services
{
    public class ConsoleLog : ILog
    {
        public ConsoleLog(int a)
        {

        }
        public void Log()
        {
            Console.WriteLine("Consola loglama işlemi gerçekleştirildi");
        }
    }
}
