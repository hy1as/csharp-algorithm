using System.Text;

int.TryParse(Console.ReadLine(), out var countOfTestCase);
var sb = new StringBuilder();
for (var i = 0; i < countOfTestCase; i++)
{
    int.TryParse(Console.ReadLine(), out var n);
    var memo = new int[11];
    memo[0] = 1;
    for (var j = 1; j <= n; j++)
    {
        memo[j] += memo[j - 1];
        if (j >= 2)
        {
            memo[j] += memo[j - 2];
        }
        if (j >= 3)
        {
            memo[j] += memo[j - 3];
        }
    }

    sb.AppendLine(memo[n].ToString());
}

Console.WriteLine(sb.ToString());