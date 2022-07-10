using Inversion.Of.Control.Services;

namespace Inversion.Of.Control
{
    public class Example
    {
        public Example()
        {
            IServiceCollection services = new ServiceCollection();
            services.Add(new ServiceDescriptor(typeof(ConsoleLog), new ConsoleLog(5)));
            services.Add(new ServiceDescriptor(typeof(TextLog), new TextLog()));

            ServiceProvider provider = services.BuildServiceProvider();
            provider.GetService<ConsoleLog>();
            provider.GetService<TextLog>();
        }
    }
}
