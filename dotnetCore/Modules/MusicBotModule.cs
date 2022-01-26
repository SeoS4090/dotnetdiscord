using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord.Commands;

namespace dotnetCore.Modules
{
    // 모듈 클래스의 접근제어자가 public이면서 ModuleBase를 상속해야 모듈이 인식된다.
    public class MusicModule : ModuleBase<SocketCommandContext>
    {
        /// <summary>
        /// !hi 명령어를 입력했을 때 실행되는 함수
        /// </summary>
        [Command("재생")]
        [Alias("p", "P","play","Play","wotod","WOTOD")]
        public async Task MusicPlayCommand()
        {
            //ModuleBase를 상속하면 Context 변수를 통해 답장을 보낼 수 있다.
            await Context.Channel.SendMessageAsync("Play Music");
        }
    }
}
