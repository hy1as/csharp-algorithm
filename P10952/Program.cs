using System.Text;

var sb = new StringBuilder();
while (true)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
    var a = input[0];
    var b = input[1];
    if (a == 0 && b == 0)
    {
        break;
    }

    sb.AppendLine($"{a + b}");
}

Console.WriteLine(sb.ToString());