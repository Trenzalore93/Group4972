//  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int[] GenArray(int length, int min, int max) //заполняем массив случайными значениями от -9 до 9 с длиной 12
{
    int[] array = new int[12];

    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max+1);
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
void InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
}

int[] array = GenArray(12, -9, 9);
PrintArray(array);
InverseArray(array);
Console.WriteLine("");
PrintArray(array);