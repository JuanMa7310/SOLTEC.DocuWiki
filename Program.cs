using System.Text.Json;

var gsourcePath = Path.Combine(Directory.GetCurrentDirectory(), "Source");
var goutputPath = Path.Combine(Directory.GetCurrentDirectory(), "Docs");

Directory.CreateDirectory(goutputPath);
Console.WriteLine($"> Generating documentation from: {gsourcePath}");

var gindex = new List<Dictionary<string, string>>();

foreach (var _file in Directory.GetFiles(gsourcePath, "*.xml", SearchOption.AllDirectories))
{
    var _className = Path.GetFileNameWithoutExtension(_file);
    var _htmlFilePath = Path.Combine(goutputPath, _className + ".html");
    var _xmlContent = await File.ReadAllTextAsync(_file);
    var _htmlContent = $@"
<!DOCTYPE html>
<html lang='en'>
<head>
    <meta charset='UTF-8'>
    <meta name='viewport' content='width=device-width, initial-scale=1.0'>
    <title>{_className} - SOLTEC.Core</title>
    <link rel='stylesheet' href='light.css' media='(prefers-color-scheme: light)'>
    <link rel='stylesheet' href='dark.css' media='(prefers-color-scheme: dark)'>
    <script src='search.js' defer></script>
</head>
<body>
    <header>
        <img src='Images/logo.png' alt='SOLTEC Logo' class='logo'>
        <h1>SOLTEC.Core Documentation</h1>
        <input type='search' id='searchInput' placeholder='🔍 Search...'>
    </header>
    <main>
        <article>
            <h2>{_className}</h2>
            <pre>{System.Net.WebUtility.HtmlEncode(_xmlContent)}</pre>
        </article>
    </main>
</body>
</html>";

    await File.WriteAllTextAsync(_htmlFilePath, _htmlContent);

    gindex.Add(new Dictionary<string, string>
    {
        { "title", _className },
        { "url", $"{_className}.html" }
    });
}
var _indexJson = JsonSerializer.Serialize(gindex, new JsonSerializerOptions { WriteIndented = true });

await File.WriteAllTextAsync(Path.Combine(goutputPath, "index.json"), _indexJson);

Console.WriteLine("✅ Documentation with search integrated successfully generated.");