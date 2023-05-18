using System.Text;

var countOfCommands = int.Parse(Console.ReadLine());
var queue = new CustomDequeue();
var sb = new StringBuilder();
for (var i = 0; i < countOfCommands; i++)
{
    var command = Console.ReadLine().Split(" ");
    switch (command[0])
    {
        case "push_front":
            queue.PushFront(int.Parse(command[1]));
            break;
        case "push_back":
            queue.PushBack(int.Parse(command[1]));
            break;
        case "pop_front":
            sb.AppendLine(queue.PopFront());
            break;
        case "pop_back":
            sb.AppendLine(queue.PopBack());
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
            throw new Exception("Invalid command");
    }
}

Console.WriteLine(sb.ToString());

class CustomDequeue
{
    private List<int> _memory = new List<int>();

    public CustomDequeue()
    {
    }

    public void PushFront(int n)
    {
        _memory.Insert(0, n);
    }

    public void PushBack(int n)
    {
        _memory.Add(n);
    }

    public string PopFront()
    {
        if (_memory.Count == 0)
        {
            return "-1";
        }

        var ret = _memory[0].ToString();
        _memory.RemoveAt(0);
        return ret;
    }

    public string PopBack()
    {
        if (_memory.Count == 0)
        {
            return "-1";
        }

        var ret = _memory[^1].ToString();
        _memory.RemoveAt(_memory.Count - 1);
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