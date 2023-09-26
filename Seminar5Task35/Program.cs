// Задача №35
// Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] GenArray(int length, int min, int max)
{
    int[] array = new int[length];

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

int CountElement(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] >= 10) && (array[i] <= 99)) count++;
    }
    return count;
}

int[] arr = GenArray(123, 0, 1000);
PrintArray(arr);
int answer = CountElement(arr);
Console.WriteLine($"Количество двухзначных элементов массива: {answer}");
