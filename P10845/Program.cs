using System.Text;

var countOfCommands = int.Parse(Console.ReadLine()!);
var queue = new CustomQueue();
var sb = new StringBuilder();
for (var i = 0; i < countOfCommands; i++)
{
    var command = Console.ReadLine()!.Split(" ");
    switch (command[0])
    {
        case "push":
            queue.Push(int.Parse(command[1]));
            break;
        case "pop":
            sb.AppendLine(queue.Pop());
            break;
        case "size":
            sb.AppendLine(queue.Size());
            break;
        case "empty":
            sb.AppendLine(queue.Empty());
            break;
        case "front":
            sb.AppendLine(queue.Front());
            break;
        case "back":
            sb.AppendLine(queue.Back());
            break;
        default:
            throw new Exception("Invalid Command");
    }
}

Console.WriteLine(sb.ToString());

class CustomQueue
{
    private readonly List<int> _memory;

    public CustomQueue()
    {
        _memory = new List<int>();
    }

    public void Push(int n)
    {
        _memory.Add(n);
    }

    public string Pop()
    {
        if (_memory.Count == 0)
        {
            return "-1";
        }

        var ret = _memory[0].ToString();
        _memory.RemoveAt(0);
        return ret;
    }

    public string Size()
    {
        return _memory.Count.ToString();
    }

    public string Empty()
    {
        return _memory.Count == 0 ? "1" : "0";
    }

    public string Front()
    {
        return _memory.Count == 0 ? "-1" : _memory[0].ToString();
    }

    public string Back()
    {
        return _memory.Count == 0 ? "-1" : _memory[^1].ToString();
    }
}