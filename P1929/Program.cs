using System.Text;

var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
var start = input[0];
var end = input[1];
var sieve = new bool[end + 1];
Array.Fill(sieve, false);
sieve[0] = true;
sieve[1] = true;
for (var i = 2; i * i <= end; i++)
{
    if (sieve[i])
    {
        continue;
    }
    for (var j = 2; i * j <= end; j++)
    {
        sieve[i * j] = true;
    }
}

var sb = new StringBuilder();
for (var i = start; i <= end; i++)
{
    if (!sieve[i])
    {
        sb.AppendLine(i.ToString());
    }
}

Console.WriteLine(sb.ToString());