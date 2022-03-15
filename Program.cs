using System.Threading.Tasks;
using System;
using Discord;
using Discord.WebSocket;

namespace DiscordKEWUDDbot
{
    class Program
    {
        DiscordSocketClient client;

        static void Main(string[] args)
            => new Program().MainAsync().GetAwaiter().GetResult();

        private async Task MainAsync()
        {
            client = new DiscordSocketClient();
            client.MessageReceived += CommandsHandler;
            client.Log += Log;
            

            var token = "OTQ4ODQ0NTE2NTI0Mjk0MTk0.YiBuUQ.n1_D7mKW09Er6jOYqLQ5DhK5DIY";
            await client.LoginAsync(TokenType.Bot, token);
            await client.StartAsync();
              

            Console.ReadLine();
        }

        private Task Log(LogMessage msg)
        {
            Console.WriteLine(msg.ToString());
            return Task.CompletedTask;
        }

        private Task CommandsHandler(SocketMessage msg)
        {
            if(!msg.Author.IsBot)
            {
                switch (msg.Content)
               {
                    case "!Ютуб":
                            msg.Channel.SendMessageAsync("https://www.youtube.com/channel/UC7nZ87dqQKSw-2N6GhN3vsQ");
                            msg.Channel.SendMessageAsync("https://www.youtube.com/channel/UCBkqp0-Ik3345imNSnI-7xg/videos");
                            msg.Channel.SendMessageAsync("https://www.youtube.com/channel/UChyqpeY_oF8BBfaemv-kuqg");
                            break;
                }
            }
            return Task.CompletedTask;
        }
    }
}
