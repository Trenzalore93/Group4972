﻿// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).


int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string FindXY(int numQuarter)
{
    if (numQuarter == 1) return "x>0, y>0";
    if (numQuarter == 2) return "x<0, y>0";
    if (numQuarter == 3) return "x<0, y<0";
    if (numQuarter == 4) return "x>0, y<0";
    return String.Empty;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numQuarter = ReadData("Введите номер четверти: ");
string element = FindXY(numQuarter);
PrintResult("Возможные значениы: "+element);
