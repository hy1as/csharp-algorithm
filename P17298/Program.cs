var countOfNumbers = int.Parse(Console.ReadLine());
var groupOfNumbers = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
var stack = new Stack<int>();
var answer = new int[countOfNumbers];
Array.Fill(answer, -1);
for (var i = 0; i < countOfNumbers; i++)
{
    var number = groupOfNumbers[i];
    if (stack.Count != 0)
    {
        var top = stack.Peek();
        while (stack.Count > 0 && groupOfNumbers[top] < number)
        {
            var index = stack.Pop();
            answer[index] = number;
            if (stack.Count > 0)
            {
                top = stack.Peek();
            }
        }
    }

    stack.Push(i);
}

Console.WriteLine(string.Join(" ", answer));