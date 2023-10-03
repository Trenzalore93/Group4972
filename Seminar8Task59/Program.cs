// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.

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

void FindMinElem(int[,] array, ref int x, ref int y) // изменение x и y внутри метода
{
    int min = array[0, 0];
    x = 0;
    y = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                x = i;
                y = j;
            }
        }
    }
}

int[,] Update2DArray(int[,] array, int x, int y)
{
    int[,] res = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int m = 0; 
    int n = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i != x)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (j != y)
                {
                    res[m, n] = array[i, j];
                    n++;
                }
            }
            m++;
            n = 0;
        }

    }
    return res;
}

int[,] array = Fill2DArray(5, 5, 1, 10);
Print2DArray(array);
Console.WriteLine("");
int x = 0;
int y = 0;
FindMinElem(array, ref x, ref y);
int[,] result = Update2DArray(array, x, y);
Print2DArray(result);