using FileHelper;

var dna = await "test.txt".ReadLinesFromHere();

if (dna.Length != 2)
{
    Console.WriteLine("Invalid DNA");
    Environment.Exit(-1);
}

if (dna[0].Length != dna[1].Length)
{
    Console.WriteLine("Invalid DNA");
    Environment.Exit(-1);
}

var length = dna[0].Length;

var hammingDistance = 0;

for (var i = 0; i < length; i++)
{
    if (dna[0][i] != dna[1][i])
    {
        hammingDistance++;
    }
}

Console.WriteLine(hammingDistance);