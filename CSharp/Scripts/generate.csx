using System;
using System.IO;
using System.Text.Json;

#nullable enable

const string GENERATE_JSON = "generate.json";

public struct Task
{
    public string? Output { get; set; }
    public string Template { get; set; }
    public string Keyword { get; set; }
    public string[] Tags { get; set; }
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
                var templateContent = File.ReadAllText(task.Template);

                // Create output directory if it doesn't exist
                var output = task.Output ?? "output";
                Directory.CreateDirectory(output);

                foreach (var tag in task.Tags)
                {
                    if (string.IsNullOrWhiteSpace(tag))
                        continue;

                    string newContent = templateContent.Replace(task.Keyword, tag);
                    string outputFilePath = Path.Combine(output, $"Tag{tag}.cs");

                    File.WriteAllText(outputFilePath, newContent);

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
