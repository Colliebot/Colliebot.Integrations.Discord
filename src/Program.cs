using System.Threading.Tasks;

namespace Colliebot.Integrations.Discord
{
    class Program
    {
        public static async Task Main(string[] args)
        {
            var startup = new Startup(args);
            await startup.RunAsync();
        }
    }
}
