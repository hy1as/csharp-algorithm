var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
var countOfSiblings = input[0];
var currentPosition = input[1];
var positionsOfSiblings = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse)
    .Select(n => Math.Abs(n - currentPosition)).ToArray();

int GetGCD(int a, int b)
{
    while (b != 0)
    {
        int r = a % b;
        a = b;
        b = r;
    }
    return a;
}

var gcd = positionsOfSiblings[0];
for (var i = 1; i < countOfSiblings; i++)
{
    gcd = GetGCD(gcd, positionsOfSiblings[i]);
}

Console.WriteLine(gcd);