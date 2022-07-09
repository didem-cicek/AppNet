using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Types.ReplyMarkups;
namespace AppNet.Infrastructer.Notification
{
    
    public class TelegramNotification
    {
        public static TelegramBotClient client = new TelegramBotClient("5551869565:AAHBE3angIx-_Wqnkx7EatH32ShsdAM9vbs");
        public void OnMessage(string message)
        {
            client.SendTextMessageAsync(5588893075, message);
        }

    }
}
