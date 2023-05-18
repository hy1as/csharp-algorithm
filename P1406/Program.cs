using System.Text;

var input = Console.ReadLine().ToCharArray();
var left = new Stack<char>(input);
var right = new Stack<char>();
var countOfCommands = int.Parse(Console.ReadLine());
var sb = new StringBuilder();
for (var i = 0; i < countOfCommands; i++)
{
    var commandString = Console.ReadLine().Split(" ");
    var command = commandString[0];
    switch (command)
    {
        case "L":
            if (left.Count > 0)
            {
                right.Push(left.Pop());
            }

            break;
        case "D":
            if (right.Count > 0)
            {
                left.Push(right.Pop());
            }

            break;
        case "B":
            if (left.Count > 0)
            {
                left.Pop();
            }

            break;
        case "P":
            left.Push(Convert.ToChar(commandString[1]));
            break;
        default:
            throw new Exception("Invalid command");
    }
}

sb.Append(string.Join("", left.ToArray().Reverse()));
sb.Append(string.Join("", right.ToArray()));

Console.WriteLine(sb.ToString());