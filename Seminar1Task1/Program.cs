// Задача №1
// Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine() ?? "0");
if (numA == numB * numB)
{
    Console.WriteLine("Первое число - квадрат второго.");
}
else
{
    Console.WriteLine("Первое число - НЕ квадрат второго.");
}

// В одну строку:
// Console.WriteLine(num1 == Math.Pow(num2, 2) ? "Да" : "Нет");