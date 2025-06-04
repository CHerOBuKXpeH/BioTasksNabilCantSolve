Console.WriteLine(CountRabbits(85,20));
return;

long CountRabbits(int months, int lifespan)
{
    var ageGroups = new List<long>(new long[lifespan])
    {
        [0] = 1
    };

    for (var i = 1; i < months; i++)
    {
        long newPairs = 0;
        
        for (var j = 1; j < lifespan; j++)
        {
            newPairs += ageGroups[j];
        }
        for (var j = lifespan - 1; j > 0; j--)
        {
            ageGroups[j] = ageGroups[j - 1];
        }
        ageGroups[0] = newPairs;
    }

    return ageGroups.Sum();
}