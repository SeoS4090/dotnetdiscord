using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace dotnetCore.Modules
{
    class MusicBotModule : ModuleBase<SocketCommandContext>
    {
        [Command("재생")]
        [Alias("play", "p", "Play","PLAY","wotod","WOTOD")]
        public async Task PlayMusic()
        {
            string musicURLName = Context.Message.Content.Split(' ').ToList().Last();

            Uri uriResult;
            bool isURL = Uri.TryCreate(musicURLName, UriKind.Absolute, out uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
            
            if (isURL)
                await Context.Channel.SendMessageAsync($"this is now url : {musicURLName}");
            else
                await Context.Channel.SendMessageAsync($"Play Music : {musicURLName}");

            await Context.Message.DeleteAsync();
        }
    }
}
