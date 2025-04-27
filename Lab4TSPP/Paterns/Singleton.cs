public class ResourceManager
{
    public static readonly ResourceManager Instance = new();

    private Dictionary<string, string> images;
    private Dictionary<string, string> fonts;
    private Dictionary<string, string> data;

    private ResourceManager()
    {
        images = new Dictionary<string, string>();
        fonts = new Dictionary<string, string>();
        data = new Dictionary<string, string>();
    }

    public void AddImage(string key, string path)
    {
        images[key] = path;
    }

    public string? GetImage(string key)
    {
        return images.ContainsKey(key) ? images[key] : null;
    }

    public void AddFont(string key, string fontName)
    {
        fonts[key] = fontName;
    }

    public string? GetFont(string key)
    {
        return fonts.ContainsKey(key) ? fonts[key] : null;
    }

    public void AddData(string key, string value)
    {
        data[key] = value;
    }

    public string? GetData(string key)
    {
        return data.ContainsKey(key) ? data[key] : null;
    }
}