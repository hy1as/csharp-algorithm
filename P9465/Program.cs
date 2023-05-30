using System.Text;

int.TryParse(Console.ReadLine(), out var countOfTestCase);
var sb = new StringBuilder();
for (var i = 0; i < countOfTestCase; i++)
{
    int.TryParse(Console.ReadLine(), out var countOfColumns);
    // 0 : 첫번째 줄, 1: 두번째 줄
    var groupOfStickers = new int[2, countOfColumns];
    // 0 : 안뗌, 1: 첫번째 줄, 2: 두번째 줄
    var memo = new int[countOfColumns, 3];
    for (var row = 0; row < 2; row++)
    {
        var numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
        for (var inputIndex = 0; inputIndex < countOfColumns; inputIndex++)
        {
            groupOfStickers[row, inputIndex] = numbers[inputIndex];
        }
    }

    memo[0, 0] = 0;
    memo[0, 1] = groupOfStickers[0, 0];
    memo[0, 2] = groupOfStickers[1, 0];

    for (var b = 1; b < countOfColumns; b++)
    {
        memo[b, 0] = Math.Max(memo[b - 1, 0], Math.Max(memo[b - 1, 1], memo[b - 1, 2]));
        memo[b, 1] = Math.Max(memo[b - 1, 0], memo[b - 1, 2]) + groupOfStickers[0, b];
        memo[b, 2] = Math.Max(memo[b - 1, 0], memo[b - 1, 1]) + groupOfStickers[1, b];
    }

    sb.AppendLine(Math.Max(memo[countOfColumns - 1, 0], Math.Max(memo[countOfColumns - 1, 1], memo[countOfColumns - 1, 2])).ToString());
}

Console.WriteLine(sb.ToString());