namespace MyWebApp.Models;

public static class Cache
{
    public static Dictionary<string, IReadOnlyCollection<SectionItem>> SectionCache { get; } 
        = new Dictionary<string, IReadOnlyCollection<SectionItem>>();
}
