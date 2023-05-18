using System.Text;

var sb = new StringBuilder();

while (true)
{
    var input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        break;
    }
    var numberArray = Array.ConvertAll(input.Split(" "), int.Parse);
    sb.AppendLine($"{numberArray[0] + numberArray[1]}");
}

Console.WriteLine(sb.ToString());