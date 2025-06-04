Console.WriteLine(CalculateDominantProbability(29,21, 17));
return;

static double CalculateDominantProbability(int k, int m, int n)
{
    var total = k + m + n;
    var totalPairs = total * (total - 1) / 2.0;
    
    var dominantPairs = 
        k * (k - 1) / 2.0 * 1.0 +           
        k * m * 1.0 +                       
        k * n * 1.0 +                       
        m * (m - 1) / 2.0 * 0.75 +         
        m * n * 0.5 +                       
        n * (n - 1) / 2.0 * 0.0;         

    return dominantPairs / totalPairs;
}