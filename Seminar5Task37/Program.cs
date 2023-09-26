// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

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

int[] MultiplicationMassive(int[] array)
{
    int[] outArray = new int[array.Length / 2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        outArray[i] = array[i] * array[array.Length - 1 - i];
    }
    return outArray;
}

int[] arr = GenArray(123, 0, 50);
PrintArray(arr);
int[] newArray = MultiplicationMassive(arr);
PrintArray(newArray);
