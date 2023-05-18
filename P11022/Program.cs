using System.Text;

var sb = new StringBuilder();
var countOfTestCases = int.Parse(Console.ReadLine());

for (var i = 1; i <= countOfTestCases; i++)
{
    var numberArray = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
    sb.AppendLine($"Case #{i}: {numberArray[0]} + {numberArray[1]} = {numberArray[0] + numberArray[1]}");
}

Console.WriteLine(sb.ToString());