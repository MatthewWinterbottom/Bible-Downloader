// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

using var client = new HttpClient();

var url = "https://biblehub.com/niv/matthew/13.htm";

var webHtml = await client.GetStringAsync(url);

Console.WriteLine(webHtml);