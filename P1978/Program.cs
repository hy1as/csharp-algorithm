int.Parse(Console.ReadLine());
var groupOfNumbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
var max = groupOfNumbers.Max();
var sieve = new bool[max + 1];
Array.Fill(sieve, false);
sieve[0] = true;
sieve[1] = true;
for (var i = 2; i * i <= max; i++)
{
    if (sieve[i])
    {
        continue;
    }

    for (var j = 2; i * j <= max; j++)
    {
        sieve[i * j] = true;
    }
}

var count = groupOfNumbers.Count(number => !sieve[number]);
Console.WriteLine(count);