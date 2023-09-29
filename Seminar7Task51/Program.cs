// Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int[,] Fill2DArray(int row, int column, int bottomBorder, int topBorder)
{
    int[,] array2D = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            array2D[i, j] = new Random().Next(bottomBorder, topBorder + 1); ;
        }
    }
    return array2D;
}

void Print2DArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine("");
    }
}

int MainDiagSum(int[,] array)
{
    int sum = 0;
    int min = array.GetLength(0);
    if (min > array.GetLength(1)) min = array.GetLength(1);
    for (int i = 0; i < min; i++)
    {
        sum = sum + array[i, i];
    }
    return sum;
}

int row = ReadData("введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
int[,] arr2D = Fill2DArray(row,column,1,100);
Print2DArray(arr2D);
Console.WriteLine("");
int result = MainDiagSum(arr2D);
Console.WriteLine($"Сумма элементов на главной диагонали = {result}");