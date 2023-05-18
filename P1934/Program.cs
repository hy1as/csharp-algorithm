using System.Text;

var sb = new StringBuilder();
var countOfCases = int.Parse(Console.ReadLine());

int GetGCD(int a, int b)
{
    while (b != 0)
    {
        var r = a % b;
        a = b;
        b = r;
    }
    return a;
}

int GetLCM(int a, int b)
{
    return a * b / GetGCD(a, b);
}

for (var i = 0; i < countOfCases; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
    sb.AppendLine($"{GetLCM(input[0], input[1])}");
}

Console.WriteLine(sb.ToString());