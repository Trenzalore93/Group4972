//  Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[] GenArray(int length, int min, int max) //заполняем массив случайными значениями от -9 до 9 с длиной 12
{
    int[] array = new int[12];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array) // выводим массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine("");
}

int FindDigit(int[] array, int digit)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == digit) return i;
    }
    return -1;
}

int num = ReadData("Введите число: ");
int[] arr = GenArray(12, -9, 9);
PrintArray(arr);
int answer = FindDigit(arr, num);
if (answer == (-1)) Console.WriteLine($"Числа {num} нет в массиве");
else Console.WriteLine($"Позиция числа {num} в массиве - {answer + 1}");
