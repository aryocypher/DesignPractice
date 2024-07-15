FontFactory fontFactory = new FontFactory();

// Get shared flyweight objects
IFont font1 = fontFactory.GetFont("Arial");
IFont font2 = fontFactory.GetFont("Times New Roman");

// Set intrinsic state
font1.SetSize(12);
font1.SetStyle("Regular");
font1.SetColor("Black");

font2.SetSize(14);
font2.SetStyle("Italic");
font2.SetColor("Red");

// Use flyweight objects
font1.Display("Hello, Flyweight Pattern!");
font2.Display("This is a demonstration.");

interface IFont
{
    void SetSize(int size);
    void SetStyle(string style);
    void SetColor(string color);
    void Display(string text);
}

class ConcreteFont : IFont
{
    private int size;
    private string style;
    private string color;

    public void SetSize(int size)
    {
        this.size = size;
    }

    public void SetStyle(string style)
    {
        this.style = style;
    }

    public void SetColor(string color)
    {
        this.color = color;
    }

    public void Display(string text)
    {
        Console.WriteLine($"Text: '{text}' | Size: {size} | Style: {style} | Color: {color}");
    }
}


class FontFactory
{
    private Dictionary<string, IFont> fonts = new Dictionary<string, IFont>();

    public IFont GetFont(string key)
    {
        if (!fonts.ContainsKey(key))
        {
            fonts[key] = new ConcreteFont();
        }
        return fonts[key];
    }
}