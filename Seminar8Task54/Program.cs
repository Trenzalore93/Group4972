//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// наполняем массив случайными числами
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
// метод печати массива
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
//сортировка по убыванию
void RowBubbleSort(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++) // вводим ещё одну переменную счётчика, чтобы избежать ситуации с ошибкой из-за выражений "j-1"/"j+1"
            {
                if (array[i, j] >= array[i, k])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }

            }

        }
    }
}

int[,] matrix = Fill2DArray(4, 4, 1, 10);
Print2DArray(matrix);
RowBubbleSort(matrix);
Console.WriteLine("");
Print2DArray(matrix);