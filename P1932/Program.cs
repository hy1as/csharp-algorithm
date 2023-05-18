using System.Diagnostics;
using Microsoft.VisualBasic.CompilerServices;

int.TryParse(Console.ReadLine(), out var n);
var triangle = new int[n][];
for (var i = 0; i < n; i++)
{
    triangle[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
}

var memo = new int[501, 501];
memo[0, 0] = triangle[0][0];
for (var i = 1; i < n; i++)
{
    for (var j = 0; j <= i; j++)
    {
        if (j == 0)
        {
            memo[i, j] = memo[i - 1, j] + triangle[i][j];
        }
        else if (j == i)
        {
            memo[i, j] = memo[i - 1, j - 1] + triangle[i][j];
        }
        else
        {
            memo[i, j] = Math.Max(memo[i - 1, j - 1], memo[i - 1, j]) + triangle[i][j];
        }
    }
}

var maxValue = int.MinValue;
for (var i = 0; i < n; i++)
{
    maxValue = Math.Max(maxValue, memo[n - 1, i]);
}

Console.WriteLine(maxValue);