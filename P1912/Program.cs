int.TryParse(Console.ReadLine(), out var n);
var sequence = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
var memo = new int[n];
memo[0] = sequence[0];
for (var i = 1; i < n; i++)
{
    if (memo[i - 1] > 0)
    {
        memo[i] = memo[i - 1] + sequence[i];
    }
    else
    {
        memo[i] = sequence[i];
    }
}

Console.WriteLine(memo.Max());