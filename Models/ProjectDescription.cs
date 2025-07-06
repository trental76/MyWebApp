namespace MyWebApp.Models;

public class ProjectDescription
{
    public string Overview { get; set; } = string.Empty;
    
    public List<string> TechStack { get; set; } = new List<string>();

    public List<string> ProgectTargets { get; set; } = new List<string>();
}
