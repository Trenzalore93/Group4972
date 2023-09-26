// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
// [2 0,4 9 7,2 78] -> 77,6
// (со звездочкой) Отсортируйте массив методом вставки и методом подсчета, а затем найдите разницу между первым и последним элементом. 
// Для задачи со звездочкой использовать заполнение массива целыми числами.

// double[] GenArray(int length, int min, int max)
// {
//     double[] array = new double[length];

//     for (int i = 0; i < length; i++)
//     {
//         array[i] = Math.Round(array.Next(-100, 101)*0.1, 1);
//     }
//     return array;
// }
double[] FillArray(int length, int min, int max)
{
    double [] array = new double[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(rand.Next(min, max*10)*0.1, 1);
    }
    return array;
}

void PrintArray(double[] array) // выводим массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine("");
}

double[] DifferenceMaxMin(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if(array[i]<min) min = array[i];
        if(array[i]>max) max = array[i];
    }
    double diff = max - min;
    return diff;
}

double[] array = FillArray(5, 0, 20);
PrintArray(array);
double result = DifferenceMaxMin(array);
Console.WriteLine($"Разница между максимальным и минимальным значениями массива - {result}");