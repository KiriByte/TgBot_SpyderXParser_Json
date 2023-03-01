using Telegram.Bot;
using Telegram.Bot.Types;

namespace TgBot_SpyderXParser_Json;

public class AppRun
{
    private ProductCard spyderxpro = new ProductCard("Spyder X Pro", "images/spyderxpro.jpg");
    private ProductCard spyderxelite = new ProductCard("Spyder X Elite", "images/spyderxpro.jpg");
    private static string token = "6234569651:AAGThzWRKgqmpLX-Y6Gl2GX90K6DkXIXes8";

    public void Run()
    {
        GetJsonDoc();
    }
    public void GetPrices()
    {
    }

    // public async Task SendMessage()
    // {
    //     var botClient = new TelegramBotClient(token);
    //
    //
    //     await botClient.SendTextMessageAsync(
    //         chatId: "@Kiribyte_channel",
    //         text: "test"
    //     );
    // }

    public string GetJsonDoc()
    {
        
        return "";
    }
}