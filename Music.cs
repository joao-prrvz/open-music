using System.Text.RegularExpressions;

namespace OpenMusic;

public class Music
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string? FilePath { get; set; }
    public string Audio { get; set; }
    public string Cover { get; set; }
    
    public Music(string title, string author, string filePath)
    {
        Title = title;
        Author = author;
        FilePath = filePath;
    }
    
    public Music(string title, string author, string audio, string cover)
    {
        Title = title;
        Author = author;
        Audio = audio;
        Cover = cover;
    }
}