int.TryParse(Console.ReadLine(), out var n);
var groupOfWines = new int[n];
for (var i = 0; i < n; i++)
{
    int.TryParse(Console.ReadLine(), out groupOfWines[i]);
}

var memo = new int[n];
memo[0] = groupOfWines[0];
if (n > 1)
{
    memo[1] = groupOfWines[0] + groupOfWines[1];
}

if (n > 2)
{
    memo[2] = Math.Max(memo[0] + groupOfWines[2], Math.Max(memo[1], groupOfWines[1] + groupOfWines[2]));
}

for (var i = 3; i < n; i++)
{
    memo[i] = Math.Max(memo[i - 1]
        , Math.Max(memo[i - 2] + groupOfWines[i], memo[i - 3] + groupOfWines[i] + groupOfWines[i - 1]));
}

Console.WriteLine(memo[n - 1]);