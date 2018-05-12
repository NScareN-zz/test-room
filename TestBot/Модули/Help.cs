using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestBot.Модули
{
    public class Help : ModuleBase<SocketCommandContext>
    {
        [Command("Help")]
        public async Task HelpAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Меню помощи")
                .WithDescription("Вот мои команды :\n- Hello - приветствие\n- Daniil_Pidr - узнать всю правду\n- Test_Image - команда для теста")
                .WithColor(Color.Green);

            await ReplyAsync("", false, builder.Build());
        }
    }
}
