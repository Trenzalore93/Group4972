//  Задайте массив из 12 элементов, заполненный  случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива. 
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


int[] FillArray(int min, int max, int length) //заполняем массив случайными значениями от min до max+1 с длиной length
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
}

(int, int) NegativePositiveSum(int[] array)
{
    int positiveSum = 0;
    int negativeSum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) positiveSum = positiveSum + array[i];
        else negativeSum += array[i];
    }
    return (positiveSum, negativeSum);
}

int[] array = FillArray(-9, 9, 12);
PrintArray(array);
(int positive, int negative) sum = NegativePositiveSum(array);
Console.WriteLine("");
Console.WriteLine($"Сумма позитивных чисел массива: {sum.positive}");
Console.WriteLine($"Сумма негативных чисел массива: {sum.negative}");