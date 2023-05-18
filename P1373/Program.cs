using System.Text;

var input = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => c - '0');
var sb = new StringBuilder();
Array.Reverse(input);
var count = 0;
var list = new List<int>();
while (count < input.Length)
{
    var num = input[count] + (count + 1 < input.Length ?  input[count + 1] * 2 : 0) + (count + 2 < input.Length ?  input[count + 2] * 4 : 0);
    list.Add(num);
    count += 3;
}
list.Reverse();
Console.WriteLine(string.Join("", list));