var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
var n = input[0];
var r = input[1];

long countOfFive = 0;
long countOfTwo = 0;

long GetNumberCount(int target, int divider)
{
    long count = 0;
    long currentDivider = divider;
    while (currentDivider <= target)
    {
        count += target / currentDivider;
        currentDivider *= divider;
    }

    return count;
}

countOfTwo += GetNumberCount(n, 2);
countOfFive += GetNumberCount(n, 5);

countOfTwo -= GetNumberCount(r, 2);
countOfFive -= GetNumberCount(r, 5);

countOfTwo -= GetNumberCount(n - r, 2);
countOfFive -= GetNumberCount(n - r, 5);

var countOfTen = Math.Min(countOfTwo, countOfFive); 

Console.WriteLine(countOfTen);