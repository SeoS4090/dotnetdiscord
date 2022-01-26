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


        // 모듈 클래스의 접근제어자가 public이면서 ModuleBase를 상속해야 모듈이 인식된다.
        public class BasicModule : ModuleBase<SocketCommandContext>
        {
            /// <summary>
            /// !hi 명령어를 입력했을 때 실행되는 함수
            /// </summary>
            [Command("hi")]
            [Alias("안녕", "ㅎㅇ")] //!안녕 또는 !ㅎㅇ 를 입력해도 실행 가능
            public async Task HelloCommand()
            {
                //ModuleBase를 상속하면 Context 변수를 통해 답장을 보낼 수 있다. 
                await Context.Channel.SendMessageAsync("Hello World!");
            }
        }
    }
}
