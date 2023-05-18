using System.Text;

var countOfCases = int.Parse(Console.ReadLine());
var sb = new StringBuilder();

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

for (var i = 0; i < countOfCases; i++)
{
    int[] input = Array.ConvertAll(Console.ReadLine().Trim().Split(" "), int.Parse);
    int[] slicedInput = input[1..];
    Array.Sort(slicedInput, (e1, e2) => e2 - e1); 
    var countOfNumbers = input[0];
    long sumOfGCD = 0;
    for (var j = 0; j < countOfNumbers; j++)
    {
        for (var k = j + 1; k < countOfNumbers; k++)
        {
            sumOfGCD += GetGCD(slicedInput[j], slicedInput[k]);
        }
    }

    sb.AppendLine($"{sumOfGCD}");
}

Console.WriteLine(sb.ToString());