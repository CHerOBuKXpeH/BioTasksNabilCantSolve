using FileHelper;

var dna = await "task.txt".ReadTextFromHere();

dna.Reverse()
    .Select(x => x switch 
    {
        'A' => 'T',
        'T' => 'A',
        'G' => 'C',
        'C' => 'G',
        _ => '\0'
    })
    .ToList()
    .ForEach(Console.Write);


