using System.Text;

var countOfCases = int.Parse(Console.ReadLine());
var groupOfNumbers = new List<int>();
for (var i = 0; i < countOfCases; i++)
{
    groupOfNumbers.Add(int.Parse(Console.ReadLine()));
}

var max = groupOfNumbers.Max();
var sieve = new bool[max + 1];
Array.Fill(sieve, false);
sieve[0] = true;
sieve[1] = true;
for (var i = 2; 2 * i <= max; i++)
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

var sb = new StringBuilder();
foreach (var number in groupOfNumbers)
{
    var count = 0;
    for (var i = 2; i * 2 <= number; i++)
    {
        if (!sieve[i] && !sieve[number - i])
        {
            count++;
        }
    }

    sb.AppendLine($"{count}");
}

Console.WriteLine(sb.ToString());