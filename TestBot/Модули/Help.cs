using Discord;
using Discord.Commands;
using System;
using System.IO;
using Discord.WebSocket;
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



            FileStream logfile = new FileStream(@"D:\Vitfiles\log.txt", FileMode.Append); //открытие файла на дозапись в конец файла
            StreamWriter writer = new StreamWriter(logfile); //создаем «потоковый писатель» и связываем его с файловым потоком 
            string text = " \"-Help\" ";
            string mention = Context.Message.Author.Username;
            writer.Write(DateTime.Now); //записываем в файл
            writer.Write(text);
            writer.Write("(");
            writer.Write(mention);
            writer.WriteLine(")");
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется
            //await ReplyAsync(Context.Message.Author.Mention);
        }
    }
}
