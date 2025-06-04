const int xi = 6;

var permutations = GetPermutations(xi).ToList();

Console.WriteLine(permutations.Count);

foreach (var perm in permutations)
{
    Console.WriteLine(string.Join(" ", perm));
}

return;

IEnumerable<IEnumerable<int>> GetPermutations(int x)
{
    var numbers = Enumerable.Range(1, x).ToList();
    return GetPermutationsGen(numbers, numbers.Count);
}

IEnumerable<IEnumerable<T>> GetPermutationsGen<T>(IEnumerable<T> list, int length)
{
    if (length == 1) 
        return list.Select(t => new T[] { t });

    var enumerable = list as T[] ?? list.ToArray();
    
    return GetPermutationsGen(enumerable, length - 1)
        .SelectMany(t => enumerable.Where(e => !t.Contains(e)),
            (t1, t2) => t1.Concat([t2]));
}