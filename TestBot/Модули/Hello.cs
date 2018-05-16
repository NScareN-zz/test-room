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
            int a = 10;
            await ReplyAsync("Привет!");
            await ReplyAsync($"{a}");
            /*string path = @"D:\test.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                File.Create(@"D:\test2.txt");
                string path2 = @"D:\test2.txt";
                FileInfo fileInf2 = new FileInfo(path);
                if (fileInf2.Exists)
                {
                    string text = Console.ReadLine();
                    File.WriteAllText();
                }
            }*/
            string path = @"D:\test.txt"; //Get a path to the file
            File.WriteAllText(path, "Test"); //Creates file, writes a text and closes the file. And it works!!!
        }
    }
}
