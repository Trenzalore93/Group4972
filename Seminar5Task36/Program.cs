// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [3, 7, -2, 1] -> 8
// [-4, -6, 89, 6] -> 0
// (со звездочкой) Найдите все пары в массиве и выведите пользователю

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

int SumUnevenIndex(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) 
        {
            sum = sum + array[i];
            Console.WriteLine($"{i} - {array[i]} ");
        }
    }
    return sum;
}

int[] arr = GenArray(15, 0, 20);
PrintArray(arr);
int sumUneven = SumUnevenIndex(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {sumUneven}");