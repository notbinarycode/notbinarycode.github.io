namespace ToplapLisbon;

public enum WebPage { About, Projects };

public class PageData
{
    public WebPage WebPage { get; set; } = WebPage.About;
}