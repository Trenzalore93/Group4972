// . Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04  0,0 0,1 0,2 0,3 -> 1,3 2,3 3,3 -> 3,2 3,1 3,0 -> 2,0 1,0 -> 1,1 1,2 -> 2,2 2,1 
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array2D[0, 0] = 1;
for (int j = 0; j > column; j++)
{
    array2D[i, j]++;
}
for (int i = 0; i < row; i++)
{
    array2D[i, j]++;
}




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