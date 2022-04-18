// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;
using AngleSharp.Dom;
using AngleSharp.Html.Parser;

Console.WriteLine("Hello, World!");

using var client = new HttpClient();

var url = "https://biblehub.com/niv/matthew/13.htm";

var webHtml = await client.GetStringAsync(url);

Console.WriteLine(webHtml);

var parser = new HtmlParser();

var document = parser.ParseDocument(webHtml);

var regions = document.QuerySelectorAll(".reg");

foreach (var region in regions)
{
    var children = region.Children;
    
    
}

var textFromRegions = regions.SelectMany(x => x.ChildNodes.OfType<IText>().Select(x => x.Text));

var textTogether = string.Join(Environment.NewLine, textFromRegions);

Console.WriteLine(textTogether);





