int.TryParse(Console.ReadLine(), out var X);
var memo = new int[X + 1];
memo[1] = 0;
for (var i = 2; i <= X; i++)
{
    memo[i] = memo[i - 1] + 1;
    if (i % 2 == 0)
    {
        memo[i] = Math.Min(memo[i], memo[i / 2] + 1);
    }

    if (i % 3 == 0)
    {
        memo[i] = Math.Min(memo[i], memo[i / 3] + 1);
    }
}

Console.WriteLine(memo[X]);