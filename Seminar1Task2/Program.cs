﻿// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine() ?? "0");
int max = numA;
if (numB > numA)
{
    max = numB;
}
Console.WriteLine("Максимальное число: "+max);
