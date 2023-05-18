var input = int.Parse(Console.ReadLine());
var answer = 1;
for (var i = 2; i <= input; i++)
{
    answer *= i;
}

Console.WriteLine(answer);