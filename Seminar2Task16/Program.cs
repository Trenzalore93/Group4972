// Задача №16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine() ?? "0");
bool test1 = (numA == numB * numB);
bool test2 = (numB == numA * numA);
if (test1) Console.WriteLine("Первое число - квадрат второго.");
if (test2) Console.WriteLine("Второе число - квадрат первого.");
if (!(test1 || test2)) //логическое ИЛИ
{
    Console.WriteLine("Числа не являются квадратами друг друга.");
}