using System.Text;

var ord = new[] {"000", "001", "010", "011", "100", "101", "110", "111"};
var input = Array.ConvertAll(Console.ReadLine().ToCharArray(), c => c - '0');
var sb = new StringBuilder();

if (input.Length == 1 && input[0] == 0)
{
    sb.Append('0');
}
else
{
    for (var i = 0; i < input.Length; i++)
    {
        var str = string.Empty;
        var num = input[i];
        if (i == 0)
        {
            str = num switch
            {
                1 => "1"
                , 2 => "10"
                , 3 => "11"
                , 4 => "100"
                , 5 => "101"
                , 6 => "110"
                , 7 => "111"
                , _ => str
            };
        }
        else
        {
            str = ord[num];
        }

        sb.Append(str);
    }
}


Console.WriteLine(sb.ToString());