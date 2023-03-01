namespace TgBot_SpyderXParser_Json;

public class ProductCard
{
    public string Name { get; set; }
    public double OldPrice { get; set; }
    public double NewPrice { get; set; }
    public string ImageSource { get; set; }

    public ProductCard(string name, string imageSource)
    {
        Name = name;
        ImageSource = imageSource;
    }
    public ProductCard(){}
}