var lengthOfSequence = int.Parse(Console.ReadLine());
var sequence = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
var max = sequence.Max();
var answer = new int[sequence.Length];
Array.Fill(answer, -1);
var groupOfCountNumber = new int[max + 1];
Array.Fill(groupOfCountNumber, 0);
foreach (var number in sequence)
{
    groupOfCountNumber[number]++;
}

var stack = new Stack<int>();
for (var i = 0; i < lengthOfSequence; i++)
{
    var number = sequence[i];
    if (stack.Count > 0) {
        var top = stack.Peek(); // 1
        while (stack.Count > 0 && groupOfCountNumber[sequence[top]] < groupOfCountNumber[number])
        {
            answer[top] = number;
            stack.Pop();
            if (stack.Count > 0)
            {
                top = stack.Peek();
            }
        }
    }
    stack.Push(i);
}

Console.WriteLine(string.Join(" ", answer));