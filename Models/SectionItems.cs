namespace MyWebApp.Models;

public class SectionItems
{
    public IReadOnlyCollection<SectionItem> Items { get; set; } = new List<SectionItem>();
}
