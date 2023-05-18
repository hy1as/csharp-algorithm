var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

int GetGCD(int a, int b)
{
    while (b != 0)
    {
        var r = a % b;
        a = b;
        b = r;
    }
    return a;
}

var gcd = GetGCD(input[0], input[1]);

Console.WriteLine($"{gcd}\n{input[0] * input[1] / gcd}");