var N = int.Parse(Console.ReadLine());
var countOfTwo = 0;
var countOfFive = 0;

for (var i = 1; i <= N; i++)
{
    var number = i;
    while (number % 2 == 0)
    {
        number /= 2;
        countOfTwo++;
    }

    while (number % 5 == 0)
    {
        number /= 5;
        countOfFive++;
    }
}

Console.WriteLine(Math.Min(countOfTwo, countOfFive));