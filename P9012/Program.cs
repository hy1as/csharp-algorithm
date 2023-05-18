using System.Text;

var countOfCases = int.Parse(Console.ReadLine());
var sb = new StringBuilder();
for (var i = 0; i < countOfCases; i++)
{
    var groupOfParenthesis = Console.ReadLine().ToCharArray();
    var stack = new Stack<char>();
    var isInvalid = false;
    foreach (var parenthesis in groupOfParenthesis)
    {
        if (parenthesis == '(')
        {
            stack.Push('(');
        }
        else
        {
            if (stack.Count > 0 && stack.Peek() == '(')
            {
                stack.Pop();
            }
            else
            {
                isInvalid = true;
                break;
            }
        }
    }
    sb.AppendLine(isInvalid || stack.Count != 0 ? "NO" : "YES");
}

Console.WriteLine(sb.ToString());