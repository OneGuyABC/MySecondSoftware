using System;

Console.WriteLine("Welcome to my second software");
Console.WriteLine($@"It is calculator!");
Console.Write("first number = ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine($"You entered {a}");
Console.Write("second numbe = ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine($"You entered {b}");
Console.WriteLine($"a + b = {a + b}");
Console.WriteLine($"a - b = {a - b}");
Console.WriteLine($"a * b = {a * b}");
Console.WriteLine($"a / b = {a / b}");
Console.WriteLine($"(a + b)^2 = {Math.Pow(a, 2) + 2*a*b + Math.Pow(b, 2)}");
Console.WriteLine($"(a - b)^2 = {Math.Pow(a, 2) - 2*a*b + Math.Pow(b, 2)}");
