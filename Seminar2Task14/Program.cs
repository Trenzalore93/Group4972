﻿// Задача №14
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine(num % 7 == 0 && num % 23 == 0 ? "Кратно" : "Не кратно");