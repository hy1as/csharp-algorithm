using System.Text;

int.TryParse(Console.ReadLine(), out var countOfTestCases);
var sb = new StringBuilder();
var memo = new int[1000001];
for (var i = 0; i < countOfTestCases; i++)
{
    int.TryParse(Console.ReadLine(), out var N);
    var answer = 0;
    for (var k = 1; k <= N; k++)
    {
        if (memo[k] == 0)
        {
            var smallAnswer = 0;
            for (var j = 1; j * j <= k; j++)
            {
                if (k % j == 0)
                {
                    smallAnswer += j != k / j ? j + k / j : j;
                }
            }

            memo[k]= smallAnswer;
        }

        answer += memo[k];
    }

    sb.AppendLine(answer.ToString());
}

Console.WriteLine(sb.ToString());