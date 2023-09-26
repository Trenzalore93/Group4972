// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.) 
// Например:
// [1 2 3 4 5] -> [5 4 3 2 1] [6 7 3 6] -> [6 3 7 6]
// Комментарий: эту задачу можно решить 2 способами: 1) менять числа местами в исходном массиве; 2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.

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

int[] NewArraySwapped(int[] array)
{
    int[] outArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        outArray[array.Length - 1 - i] = array[i];
    }
    return outArray;
}

void RevertArray(int[] array)
{
    // int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        (array[array.Length - 1 - i], array[i]) = (array[i], array[array.Length - 1 - i]);
        // temp = array[array.Length - 1 - i];
        // array[array.Length - 1 - i] = array[i];
        // array[i] = temp;
    }
}

int[] arr = GenArray(15, 1, 100);
int[] newArr1 = NewArraySwapped(arr);
Console.WriteLine("Исходный массив");
PrintArray(arr);
Console.WriteLine("Новый массив");
PrintArray(newArr1);

RevertArray(arr);
Console.WriteLine("Перевёрнутый вторым методом массив");
PrintArray(arr);
