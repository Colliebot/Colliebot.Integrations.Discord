using System.Threading.Tasks;

namespace Colliebot.Integrations.Discord
{
    class Program
    {
        public static Task Main(string[] args)
            => Startup.RunAsync(args);
    }
}
