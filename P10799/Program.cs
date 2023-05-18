var input = Console.ReadLine().ToCharArray();
var count = 0;
var stack = new Stack<char>();
var prev = '\0';
foreach (var parenthesis in input)
{
    if (parenthesis == '(')
    {
        stack.Push(parenthesis);
    }
    else
    {
        stack.Pop();
        if (prev == '(')
        {
            count += stack.Count;
        }
        else
        {
            count += 1;
        }
    }
    prev = parenthesis;
}

Console.WriteLine(count);