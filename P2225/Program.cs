var input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
var memo = new long[201, 201];
var N = input[0];
var K = input[1];
var modValue = 1000000000;
memo[0, 0] = 1;
for (var i = 1; i <= K; i++)
{
    for (var j = 0; j <= N; j++)
    {
        for (var l = 0; l <= j; l++)
        {
            memo[i, j] += memo[i - 1, j - l];
        }
        memo[i, j] %= modValue;
    }
}

Console.WriteLine(memo[K, N]);