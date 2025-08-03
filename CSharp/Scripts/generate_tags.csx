using System;
using System.IO;
using System.Text.Json;

#nullable enable

const string GENERATE_JSON = "generate_tags.json";

public struct Task
{
    public string? Output { get; set; }
    public string Template { get; set; }
    public string[] Keywords { get; set; }
    public string[][] Tags { get; set; }
}

public struct Config
{
    public Task[] Tasks { get; set; }
}

try
{
    var json = File.ReadAllText(GENERATE_JSON);
    var config = JsonSerializer.Deserialize<Config>(json);

    if (config.Tasks != null)
    {
        foreach (var task in config.Tasks)
        {
            if (task.Tags != null)
            {
                var template = File.ReadAllText(task.Template);

                // Create output directory if it doesn't exist
                var output = task.Output ?? "output";
                Directory.CreateDirectory(output);

                foreach (var tags in task.Tags)
                {
                    string content = template;

                    for (int n = 0; n < tags.Length; n++)
                    {
                        var tag = tags[n];
                        var keyword = task.Keywords[n];

                        if (string.IsNullOrWhiteSpace(tag))
                            continue;

                        content = content.Replace(keyword, tag);
                    }

                    string outputFilePath = Path.Combine(output, $"Tag{tags[0]}.cs");
                    File.WriteAllText(outputFilePath, content);

                    Console.WriteLine($"Created file: {outputFilePath}");
                }
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"An error occurred: {ex.Message}");
}
