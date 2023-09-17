// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// Например:
// [1,0,1,1,0,1,0,0]

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
int[] FillArray(int length)
{
    int[] array = new int[length];
    Random md = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i]=md.Next(0,2);
    }
    return array;
}
void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length-1; i++)
    {
        Console.Write(array[i]+",");
    }
    Console.Write(array[array.Length-1]+"]");
}

int length=ReadData("Введите длину массива: ");
int[] array=FillArray(length);
PrintArray(array);
