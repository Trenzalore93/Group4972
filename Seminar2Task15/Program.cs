﻿// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
//* Сделать вариант с использованием конструкции Dictionary

Console.WriteLine("Введите число дня недели: ");
int dayNumber = int.Parse(Console.ReadLine() ?? "0"); //получаем число
var dictWeek = new Dictionary<int, string>()//создаём словарь и наполняем
{
    [1] = "понедельник",
    [2] = "вторник",
    [3] = "среда",
    [4] = "четверг",
    [5] = "пятница",
    [6] = "суббота",
    [7] = "воскресенье",
};
if (dayNumber==6||dayNumber==7) Console.WriteLine("Сегодня выходной - "+dictWeek[dayNumber]); //условие для выходных
else Console.WriteLine("Сегодня не выходной - "+dictWeek[dayNumber]);//условие для будней

