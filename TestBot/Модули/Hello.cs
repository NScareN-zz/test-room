using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestBot.Модули
{
    public class Hello : ModuleBase<SocketCommandContext>
    {
        [Command("Виталя, привет")]
        public async Task HelloAsync()
        {
            await ReplyAsync("Привет!");
        }
    }
}
