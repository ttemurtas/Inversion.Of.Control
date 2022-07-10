using Inversion.Of.Control.Services.Interfaces;

namespace Inversion.Of.Control.Services
{
    public class TextLog : ILog
    {
        public void Log()
        {
            Console.WriteLine("Text dosyasına loglama işlemi gerçekleştirdi");
        }
    }
}
