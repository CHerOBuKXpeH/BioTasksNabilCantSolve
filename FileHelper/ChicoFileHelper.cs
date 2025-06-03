namespace FileHelper;

public static class ChicoFileHelper
{
    public static async Task<string[]> ReadLinesFromHere(this string path)
    {
        string[] result = [];
        
        try
        {
            result = await File.ReadAllLinesAsync(path);
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException)
        {
            Console.WriteLine("Could not read file");
            Environment.Exit(-1);
        }
        
        return result;
    }
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

    public static async Task<List<FastaRecord>> ReadFastaFromHere(this string path)
    {
        var result = new List<FastaRecord>();
        var textRaw = string.Empty;
        
        try
        {
            textRaw = await File.ReadAllTextAsync(path);
        }
        catch (Exception e) when (e is IOException or UnauthorizedAccessException)
        {
            Console.WriteLine("Could not read file");
            Environment.Exit(-1);
        }
        
        var split = textRaw.Split('\n');
        var index = 0;
        FastaRecord? record = null;
        
        while (index < split.Length)
        {
            if (split[index].StartsWith('>'))
            {
                record = new FastaRecord
                {
                    Header = split[index].Replace(">", string.Empty),
                };
                result.Add(record);
            }
            else
            {
                if (record is not null)
                {
                    record.Content += split[index];
                }
            }
            index++;
        }

        return result;
    }
}