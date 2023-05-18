var countOfHouse = int.Parse(Console.ReadLine());
var memo = new int[countOfHouse + 1, 3];

// memo's column => 0 : Red, 1 : Green, 2 : Yellow
for (var i = 0; i < countOfHouse; i++)
{
    var groupOfCosts = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
    if (i == 0)
    {
        memo[1, 0] = groupOfCosts[0];
        memo[1, 1] = groupOfCosts[1];
        memo[1, 2] = groupOfCosts[2];
    }
    else
    {
        memo[i + 1, 0] = Math.Min(memo[i, 1], memo[i, 2]) + groupOfCosts[0];
        memo[i + 1, 1] = Math.Min(memo[i, 0], memo[i, 2]) + groupOfCosts[1];
        memo[i + 1, 2] = Math.Min(memo[i, 0], memo[i, 1]) + groupOfCosts[2];
    }
}

Console.WriteLine(Math.Min(memo[countOfHouse, 0], Math.Min(memo[countOfHouse, 1], memo[countOfHouse, 2])));