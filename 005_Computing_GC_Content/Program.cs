using FileHelper;

var fasta = await "test.txt".ReadFastaFromHere();

(double cgCount, string id) maxValue = (-1, "");

foreach (var line in fasta)
{
    var c = line.GetCgCount() / (double)line.GetLength();
    if (c > maxValue.cgCount)
    {
        maxValue.cgCount = c;
        maxValue.id = line.Header;
    }
}

Console.WriteLine(maxValue.id);
Console.WriteLine(maxValue.cgCount * 100);