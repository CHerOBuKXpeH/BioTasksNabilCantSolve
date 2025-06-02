using System.Text;
using FileHelper;

var dna = await "task.txt".ReadTextFromHere();

var sb = new StringBuilder();

foreach (var nucleotide in dna)
{
    sb.Append(nucleotide != 'T' ? nucleotide : 'U');
}

var result = sb.ToString();

Console.WriteLine(result);