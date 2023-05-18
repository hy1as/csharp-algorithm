using System.Text;

var sb = new StringBuilder();
var countOfTestCases = int.Parse(Console.ReadLine());
for (var i = 0; i < countOfTestCases; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
    sb.AppendLine($"{input[0] + input[1]}");
}

Console.WriteLine(sb.ToString());