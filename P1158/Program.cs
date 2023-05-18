var input = Console.ReadLine().Split(" ");
var N = int.Parse(input[0]);
var K = int.Parse(input[1]);
var list = new List<int>();
var sequence = Enumerable.Range(1, N);
var queue = new Queue<int>(sequence);
var count = 0;
while (queue.Count != 0)
{
    count++;
    var output = queue.Dequeue();
    
    if (count != K)
    {
        queue.Enqueue(output);
    }
    else
    {
        list.Add(output);
        count = 0;
    }
}

Console.WriteLine($"<{string.Join(", ",list)}>");