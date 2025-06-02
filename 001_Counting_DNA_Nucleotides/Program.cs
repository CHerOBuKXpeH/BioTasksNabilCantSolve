const string taskFilePath = "rosalind_dna.txt";

Console.WriteLine($"Trying to open {taskFilePath}");
if (!File.Exists(taskFilePath))
{
    await Console.Out.WriteLineAsync("task.txt not found. Exiting...");
    Environment.Exit(exitCode: -1);
}

string? dnaString = null;

try
{
    dnaString = await File.ReadAllTextAsync(taskFilePath);
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("Permission denied. Exiting...");
    Environment.Exit(exitCode: -1);
}

Dictionary<char, int> dnaCounting = new()
{
    ['A'] = 0,
    ['C'] = 0,
    ['G'] = 0,
    ['T'] = 0,
};

foreach (var nucleotide in dnaString.Where(nucleotide => dnaCounting.ContainsKey(nucleotide)))
{
    dnaCounting[nucleotide]++;
}

foreach (var (_, value) in dnaCounting)
{
    Console.Write($"{value} ");
}

