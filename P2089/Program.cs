var input = int.Parse(Console.ReadLine());
var list = new List<int>();

void Go(int number)
{
    if (number == 0)
    {
        return;
    }
    if (number % 2 == 0)
    {
        Go(-(number / 2));
        list.Add(0);
    }
    else
    {
        if (number > 0)
        {
            Go(-number / 2);
        }
        else
        {
            Go((-number + 1) / 2);
        }
        list.Add(1);
    }
}

if (input == 0)
{
    Console.WriteLine("0");
}
else
{
    Go(input);
    Console.WriteLine(string.Join("", list));
}