using AngleSharp.Dom;

namespace BibleDownloader;

public static class Extensions
{
    /// <summary>
    /// Gets the text of the immediate children
    /// </summary>
    /// <returns></returns>
    public static string GetTextJoined(this IElement element, string? joiner = null)
    {
        joiner ??= Environment.NewLine;
        
        var textStrings = element.ChildNodes.OfType<IText>().Select(x => x.Text);
        
        return string.Join(joiner, textStrings);
    }

    public static string GetChildText(IElement html, string existingText = "")
    {
        var textWithinCurrentNode = html.GetTextJoined();

        existingText += textWithinCurrentNode;
        
        // Now we need to look at text within children

        foreach (var child in html.Children)
        {
            GetChildText(child, existingText);
        }

        return existingText;
    }
}