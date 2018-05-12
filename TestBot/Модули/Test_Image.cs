using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestBot.Модули
{
    public class Test_Image : ModuleBase<SocketCommandContext>
    {
        [Command("Test_Image")]
        public async Task Test_ImageAsync()
        {
            Random rnd = new Random();
            int image = rnd.Next(1, 5);
            if (image == 1)
            {
                await ReplyAsync("https://media.rockstargames.com/rockstargames-newsite/uploads/135d619611408437869318458d6e1108e9e80847.png");
                await ReplyAsync("Рандомным числом было 1");
            }
            if (image == 2)
            {
                await ReplyAsync("https://media.rockstargames.com/rockstargames-newsite/uploads/1dba022093ac0292cd648a2db58820964577ab3a.jpg");
                await ReplyAsync("Рандомным числом было 2");
            }
            if (image == 3)
            {
                await ReplyAsync("https://media.rockstargames.com/rockstargames-newsite/uploads/9837531b7e7dfdc49fccb1e86cbe99d45298f8a6.jpg");
                await ReplyAsync("Рандомным числом было 3");
            }
            if (image == 4)
            {
                await ReplyAsync("https://cdn.sc.rockstargames.com/images/common/stat-panels/snapmatic.jpg");
                await ReplyAsync("Рандомным числом было 4");
            }
            if (image == 5)
            {
                await ReplyAsync("Рандомным числом было **5**");
            }
        }
    }
}
