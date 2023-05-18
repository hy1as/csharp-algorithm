using System.Text;

var countOfCommands = int.Parse(Console.ReadLine());
var stack = new CustomStack();
var sb = new StringBuilder();
for (var i = 0; i < countOfCommands; i++)
{
    var command = Console.ReadLine().Split(" ");
    switch (command[0])
    {
        case "push":
            stack.push(int.Parse(command[1]));
            break;
        case "pop":
            sb.AppendLine(stack.pop());
            break;
        case "size":
            sb.AppendLine(stack.size());
            break;
        case "empty":
            sb.AppendLine(stack.empty());
            break;
        case "top":
            sb.AppendLine(stack.top());
            break;
        default:
            throw new Exception("Invalid Command");
    }
}

Console.WriteLine(sb.ToString());

class CustomStack
{
    private List<int> memory;

    public CustomStack()
    {
        memory = new List<int>();
    }

    public void push(int number)
    {
        memory.Add(number);
    }

    public string pop()
    {
        if (memory.Count == 0)
        {
            return "-1";
        }
        var ret = memory[^1].ToString();
        memory.RemoveAt(memory.Count - 1);
        return ret;
    }

    public string top()
    {
        return memory.Count == 0 ? "-1" : memory[^1].ToString();
    }

    public string size()
    {
        return memory.Count.ToString();
    }

    public string empty()
    {
        return memory.Count == 0 ? "1" : "0";
    }
}