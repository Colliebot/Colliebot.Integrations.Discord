using Discord.Commands;
using System.Threading.Tasks;

namespace Colliebot.Integrations.Discord
{
    [RequireOwner]
    public class BotProfileModule : ModuleBase<ShardedCommandContext>
    {
        [Command("activity")]
        public Task ActivityAsync([Remainder]string content)
            => Context.Client.SetGameAsync(content);
    }
}
