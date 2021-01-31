using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using ChatBot;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ChatBot
{
    class Program
    {
        private static ITelegramBotClient botClient;
        static void Main(string[] args)
        {
            

            botClient = new TelegramBotClient("1468605892:AAF429WFqxgDpsN9cQnjQflbNz2GPsFLrsI") { Timeout = TimeSpan.FromSeconds(10)};
            var e = botClient.GetMeAsync().Result;
            Console.WriteLine(e.Id + " " + e.FirstName);

            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
            Console.ReadKey();

            botClient.StopReceiving();
        }

        private static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            string text = e?.Message?.Text;
            if (text == null||text.Equals("/start"))
                return;
            Messages messages = new Messages();
            string response = messages[text];
            await botClient.SendTextMessageAsync(
                chatId: e.Message.Chat,
                text: response).ConfigureAwait(false);
        }
    }
}
