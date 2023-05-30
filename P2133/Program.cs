int.TryParse(Console.ReadLine(), out var N);
var memo = new int[31];
memo[0] = 1;
for (var i = 2; i <= N; i++)

{
    memo[i] = memo[i - 2] * 3;
    for (var j = 4; j <= i; j += 2)
    {
        memo[i] += memo[i - j] * 2;
    }
}

Console.WriteLine(memo[N]);