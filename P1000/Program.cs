using System;
using System.Linq;

var input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);
Console.WriteLine(input.Aggregate(0, (prev, current) => prev + current));