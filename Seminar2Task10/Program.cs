﻿// №10 Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = int.Parse(Console.ReadLine() ?? "0"); // Получили числовое значение
char[] array = number.ToString().ToCharArray(); // Перевели его в массив
char secondDigit = array[1]; // Присвоили переменной значение элемента массива
Console.WriteLine("Вторая цифра: "+secondDigit); // Вывели значение второй цифры