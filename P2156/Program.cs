int.TryParse(Console.ReadLine(), out var countOfWines);
var groupOfWines = new int[countOfWines + 1];
for (var i = 0; i < countOfWines; i++)
{
    int.TryParse(Console.ReadLine(), out groupOfWines[i]);
}

var memo = new int[countOfWines];
memo[0] = groupOfWines[0];
if (countOfWines > 1)
{
    memo[1] = groupOfWines[0] + groupOfWines[1];
}
if (countOfWines > 2)
{
    memo[2] = Math.Max(groupOfWines[0] + groupOfWines[1]
        , Math.Max(groupOfWines[0] + groupOfWines[2], groupOfWines[1] + groupOfWines[2]));
}

for (var i = 3; i < countOfWines; i++)
{
    memo[i] = Math.Max(memo[i - 1]
        , Math.Max(memo[i - 2] + groupOfWines[i], memo[i - 3] + groupOfWines[i - 1] + groupOfWines[i]));
}

Console.WriteLine(memo[countOfWines - 1]);