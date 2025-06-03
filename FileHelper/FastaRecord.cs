namespace FileHelper;

public class FastaRecord
{
    public string Header { get; init; } = string.Empty;
    public string Content { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"{Header}\n{Content}";
    }

    public int GetCgCount()
    {
        return Content.Count(x => x is 'C' or 'G');
    }

    public int GetLength()
    {
        return Content.Length;
    }
}