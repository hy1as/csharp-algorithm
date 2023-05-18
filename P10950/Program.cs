var countOfCases = int.Parse(Console.ReadLine());
for (var i = 0; i < countOfCases; i++)
{
  var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
  Console.WriteLine(input[0] + input[1]);
}
