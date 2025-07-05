namespace MyWebApp.Models.Constants;

public static class SectionConstants
{
    public static List<string> Sections =
    [
        "Summary",
        "Tech Stack",
        "Projects",
        "Experience",
        "About"
    ];

    public static string DefaultSection => Sections.ElementAt(2);
}
