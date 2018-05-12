using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestBot.Модули
{
    public class Daniil_Pidr : ModuleBase<SocketCommandContext>
    {
        [Command("Виталя, Даниил - пидр?")]
        public async Task Daniil_PidrAsync()
        {
            await ReplyAsync("Если он не пидр - я не бот\nP.S. Я - бот");
        }
    }
}
