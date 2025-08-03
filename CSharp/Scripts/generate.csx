using System;
using System.IO;
using System.Text.Json;

#nullable enable

const string GENERATE_JSON = "generate.json";

public struct Output
{
    public string Folder { get; set; }
    public string Prefix { get; set; }
    public string Template { get; set; }
    
}

public struct Task
{
    public Output[] Outputs { get; set; }
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
            foreach (var output in task.Outputs)
            {
                Directory.CreateDirectory(output.Folder);

                var template = File.ReadAllText(output.Template);
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

                    string outputFilePath = Path.Combine(output.Folder, $"{output.Prefix}{tags[0]}.cs");
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
