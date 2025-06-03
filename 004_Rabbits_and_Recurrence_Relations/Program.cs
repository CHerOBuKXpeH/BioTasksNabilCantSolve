var recNumber = Console.ReadLine();

if (!int.TryParse(recNumber, out var numberParsed))
{
    Console.WriteLine("Not an integer");
    Environment.Exit(-1);
}

var kString = Console.ReadLine();

if (!int.TryParse(kString, out var kParsed))
{
    Console.WriteLine("Not an integer");
    Environment.Exit(-1);
}

Console.WriteLine(RecurrentRelation(numberParsed, kParsed));
return;

long RecurrentRelation(int n, int k) 
{
    var prev = 0L;
    var next = 1L;
    
    for (var i = 1; i < n; i++)
    {
        var sum = prev * k + next;
        prev = next;
        next = sum;
    }
    
    return next;
}

