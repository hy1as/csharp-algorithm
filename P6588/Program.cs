using System.Text;

var sb = new StringBuilder();
var groupOfNumbers = new List<int>();
while (true)
{
    var number = int.Parse(Console.ReadLine());
    if (number == 0)
    {
        break;
    }

    groupOfNumbers.Add(number);
}

var max = groupOfNumbers.Max();
var sieve = new bool[max + 1];
sieve[0] = true;
sieve[1] = true;
for (var i = 2; i <= max; i++)
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

foreach (var number in groupOfNumbers)
{
    var found = false;
    for (var i = 2; i < number; i++)
    {
        if (!sieve[i] && !sieve[number - i])
        {
            sb.AppendLine($"{number} = {i} + {number - i}");
            found = true;
            break;
        }
        
    }

    if (!found)
    {
        sb.AppendLine("Goldbach's conjecture is wrong.");
    }
}

Console.WriteLine(sb.ToString());