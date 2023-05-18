using System.Text;

var groupOfChars = Console.ReadLine()!.ToCharArray();
var sb = new StringBuilder();
var stack = new Stack<char>();
var isTag = false;
foreach (var ch in groupOfChars)
{
    switch (ch)
    {
        case '<':
            while (stack.Count != 0)
            {
                sb.Append(stack.Pop());
            }
            isTag = true;
            sb.Append(ch);
            break;
        case '>':
            isTag = false;
            sb.Append(ch);
            break;
        case ' ':
            if (!isTag)
            {
                while (stack.Count != 0)
                {
                    sb.Append(stack.Pop());
                }
            }
            sb.Append(ch);
            break;
        default:
            if (isTag)
            {
                sb.Append(ch);
            }
            else
            {
                stack.Push(ch);
            }
            break;
    }
}

while (stack.Count != 0)
{
    sb.Append(stack.Pop());
}

Console.WriteLine(sb.ToString());