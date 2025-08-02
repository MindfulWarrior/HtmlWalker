var taglist = Args[0];
var template = Args[1];
var keyword = Args[2];

try
{
    var templateContent = File.ReadAllText(template);
    var tags = File.ReadAllLines(taglist);

    // Create output directory if it doesn't exist
    string outputDir = "output";
    Directory.CreateDirectory(outputDir);

    foreach (var tag in tags)
    {
        if (string.IsNullOrWhiteSpace(tag))
            continue;
        
        string newContent = templateContent.Replace(keyword, tag);
        string outputFilePath = Path.Combine(outputDir, $"Tag{tag}.cs");

        File.WriteAllText(outputFilePath, newContent);
        
        Console.WriteLine($"Created file: {outputFilePath}");
    }

    Console.WriteLine($"Process completed in the '{outputDir}' directory.");
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
