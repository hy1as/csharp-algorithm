using System.Text;

var n = int.Parse(Console.ReadLine());
var current = 0;
var stack = new Stack<int>();
var sb = new StringBuilder();
for (var i = 0; i < n; i++)
{
    var input = int.Parse(Console.ReadLine());
    while (current < input)
    {
        current += 1;
        sb.AppendLine("+");
        stack.Push(current);
    }

    if (stack.Peek() == input)
    {
        sb.AppendLine("-");
        stack.Pop();
    }
    else
    {
        sb.Clear();
        sb.AppendLine("NO");
        break;
    }
}

Console.WriteLine(sb.ToString());
