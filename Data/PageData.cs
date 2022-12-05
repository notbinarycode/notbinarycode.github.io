namespace notbinarycode;

public enum WebPage { About, Events, Resources };

public class PageData
{
    public WebPage WebPage { get; set; } = WebPage.About;
}