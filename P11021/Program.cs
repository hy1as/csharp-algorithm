using System.Text;

var countOfTestCases = int.Parse(Console.ReadLine());
var sb = new StringBuilder();
for (var i = 1; i <= countOfTestCases; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
    sb.AppendLine($"Case #{i}: {input[0] + input[1]}");
}

Console.WriteLine(sb.ToString());