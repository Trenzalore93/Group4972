// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

using System.ComponentModel.DataAnnotations;

Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine() ?? "0");
int[] array = {num1,num2,num3};
int index = 1;
int max = array[0];
while (index<array.Length)
{
    if (array[index]>max)
    {
        max = array[index];
    }
    index++;
}
Console.WriteLine("Максимальное число: "+max);