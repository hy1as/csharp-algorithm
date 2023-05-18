using System.Text;

var countOfCases = int.Parse(Console.ReadLine());
var sb = new StringBuilder();
for (var i = 0; i < countOfCases; i++)
{
    var stack = new Stack<char>();
    var groupOfChars = Console.ReadLine().ToCharArray();
    foreach (var ch in groupOfChars)
    {
        if (ch == ' ')
        {
            while (stack.Count != 0)
            {
                sb.Append(stack.Pop());
            }

            sb.Append(' ');
        }
        else
        {
            stack.Push(ch);
        }
    }

    while (stack.Count != 0)
    {
        sb.Append(stack.Pop());
    }

    sb.AppendLine();
}

Console.WriteLine(sb.ToString());