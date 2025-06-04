Console.WriteLine(CalculateDominantOffspring([17976,16436,18791,19132,17596,18797]));
return;

static double CalculateDominantOffspring(int[] couples)
{
    double[] probabilities = [1.0, 1.0, 1.0, 0.75, 0.5, 0.0];
        
    double expectedOffspring = 0;
    
    for (var i = 0; i < 6; i++)
    {
        expectedOffspring += couples[i] * 2 * probabilities[i];
    }
        
    return expectedOffspring;
}