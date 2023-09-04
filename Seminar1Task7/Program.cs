// Задача №7
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трёхзначное число число: ");
int num = int.Parse(Console.ReadLine() ?? "0");
if (num > 99 && num < 1000)
{
    int lastDigit = num % 10;
    Console.WriteLine("Последняя цифра числа: " + lastDigit);
}
else
{
    Console.WriteLine("Число не трёхзначное.");
}