int.TryParse(Console.ReadLine(), out var N);
var memo = new long[91, 2];
memo[1, 0] = 0;
memo[1, 1] = 1;
for (var i = 2; i <= N; i++)
{
    memo[i, 0] = memo[i - 1, 0] + memo[i - 1, 1];
    memo[i, 1] = memo[i - 1, 0];
}

Console.WriteLine(memo[N, 0] + memo[N, 1]);