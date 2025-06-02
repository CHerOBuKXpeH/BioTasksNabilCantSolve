namespace FileHelper;

public static class ChicoFileHelper
{
    public static async Task<string> ReadTextFromHere(this string path)
    {
        var result = string.Empty;
        
        try
        {
            result = await File.ReadAllTextAsync(path);
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException)
        {
            Console.WriteLine("Could not read file");
            Environment.Exit(-1);
        }
        
        return result;
    }
}