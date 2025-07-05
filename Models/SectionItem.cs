namespace MyWebApp.Models;

public class SectionItem
{
    public string SectionName { get; set; } = string.Empty;

    public string Category { get; set; } = string.Empty;

    public string Title { get; set; } = string.Empty;

    public string Status { get; set; } = string.Empty;

    public int Priority { get; set; }

    public bool IsPrivate { get; set; }

    public bool IsDeleted { get; set; }

    public string Description { get; set; } = string.Empty;

    public string Icon { get; set; } = string.Empty;

    public string Link { get; set; } = string.Empty;

    public object? TechStack { get; set; }

    public object? ProgectTargets { get; set; }
}
