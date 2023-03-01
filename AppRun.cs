using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Telegram.Bot;
using Telegram.Bot.Types;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

namespace TgBot_SpyderXParser_Json;

public class AppRun
{
    private ProductCard spyderxpro = new ProductCard("Spyder X Pro", "images/spyderxpro.jpg");
    private ProductCard spyderxelite = new ProductCard("Spyder X Elite", "images/spyderxpro.jpg");
    private static string token = "6234569651:AAGThzWRKgqmpLX-Y6Gl2GX90K6DkXIXes8";
    private static string urlJson = "https://goto.datacolor.com/webshop/data/";
    private Root? _objectJson;

    public async Task Run()
    {
        DeserializeJson(await GetJsonDoc());
        GetPrice();
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

    public async Task<string> GetJsonDoc()
    {
        var client = new HttpClient();
        var jsonString = await client.GetStringAsync(urlJson);
        return jsonString;
    }

    public void DeserializeJson(string jsonString)
    {
        _objectJson = JsonConvert.DeserializeObject<Root>(jsonString);
    }

    public void GetPrice()
    {
        if (_objectJson?.price.list.sxp100 is JObject)
        {
            spyderxpro.OldPrice = _objectJson?.price.list.sxp100["old"];
            spyderxpro.NewPrice = _objectJson?.price.list.sxp100["price"];
        }

        if (_objectJson?.price.list.sxe100 is JObject)
        {
            spyderxelite.OldPrice = _objectJson?.price.list.sxe100["old"];
            spyderxelite.NewPrice = _objectJson?.price.list.sxe100["price"];
        }
    }


    public class Root
    {
        public Price price { get; set; }
    }

    public class Price
    {
        public List list { get; set; }
    }

    public class List
    {
        public dynamic cr100 { get; set; }
        public dynamic crm100 { get; set; }
        public dynamic crp100 { get; set; }
        public dynamic ssf100 { get; set; }
        public dynamic stp100 { get; set; }
        public dynamic stpp100 { get; set; }
        public dynamic susbc100 { get; set; }
        public dynamic sck100 { get; set; }
        public dynamic sck300 { get; set; }
        public dynamic sck100rc { get; set; }
        public dynamic sck200 { get; set; }
        public dynamic sc200 { get; set; }
        public dynamic slc100 { get; set; }
        public dynamic s4sr100 { get; set; }
        public dynamic sxcap100 { get; set; }
        public dynamic sxd100 { get; set; }
        public dynamic sxe100 { get; set; }
        public dynamic sxmp100 { get; set; }
        public dynamic sxpk050 { get; set; }
        public dynamic sxp100 { get; set; }
        public dynamic sxssr100 { get; set; }
        public dynamic @default { get; set; }
    }
}