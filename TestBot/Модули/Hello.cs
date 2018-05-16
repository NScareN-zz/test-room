using Discord.Commands;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace TestBot.Модули
{
    public class Hello : ModuleBase<SocketCommandContext>
    {
        [Command("Виталя, привет")]
        public async Task HelloAsync()
        {
            string usermention = Context.Message.Author.Mention;
            await ReplyAsync($"Привет, {usermention}!");



            FileStream logfile = new FileStream(@"D:\Vitfiles\log.txt", FileMode.Append); //открытие файла на дозапись в конец файла
            StreamWriter writer = new StreamWriter(logfile); //создаем «потоковый писатель» и связываем его с файловым потоком 
            string text = " \"-Виталя, привет\" ";
            string mention = Context.Message.Author.Username;
            writer.Write(DateTime.Now); //записываем в файл
            writer.Write(text);
            writer.Write("(");
            writer.Write(mention);
            writer.WriteLine(")");
            writer.Close(); //закрываем поток. Не закрыв поток, в файл ничего не запишется 
        }
    }
}
