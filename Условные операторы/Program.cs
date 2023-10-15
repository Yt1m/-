using System;

Console.WriteLine("Введите первую сторону треугольника");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника");
int c = int.Parse(Console.ReadLine());

if ((a < b + c) ^ (b < a + c) ^ (c < a + b))
{
    Console.WriteLine("Возможно");
}
else Console.WriteLine("Невозможно");