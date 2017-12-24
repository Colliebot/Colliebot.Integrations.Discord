using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.Configuration;
using System.Reflection;
using System.Threading.Tasks;

namespace Colliebot.Integrations.Discord
{
    public class StartupService
    {
        private readonly DiscordSocketClient _discord;
        private readonly CommandService _commands;
        private readonly IConfigurationRoot _config;

        public StartupService(
            DiscordSocketClient discord,
            CommandService commands,
            IConfigurationRoot config)
        {
            _config = config;
            _discord = discord;
            _commands = commands;
        }

        public async Task StartAsync()
        {
            await _discord.LoginAsync(TokenType.Bot, _config["discord:token"]);
            await _discord.StartAsync();

            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());
        }
    }
}
