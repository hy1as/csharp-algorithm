int.TryParse(Console.ReadLine(), out var N);
var memo = new int[N + 1];
memo[0] = 0;
memo[1] = 1;
for (var i = 2; i <= N; i++)
{
    memo[i] = i;
    for (var j = 1; j * j <= i; j++)
    {
        memo[i] = Math.Min(memo[i], memo[i - j * j] + 1);
    }
}

Console.WriteLine(memo[N]);