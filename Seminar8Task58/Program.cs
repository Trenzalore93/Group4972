// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
//проверяем, одинаковы ли размеры массивов
bool TestArrays(int[,] arrayA, int[,] arrayB)
{
    if (arrayA.GetLength(0) == arrayB.GetLength(0) && arrayA.GetLength(1) == arrayB.GetLength(1)) return true;
    else return false;
}
//перемножаем элементы массивов
int[,] MultiplyArrays(int[,] arrayA, int[,] arrayB)
{
    int[,] multiArray = new int[arrayA.GetLength(0), arrayA.GetLength(1)];
    for (int i = 0; i < arrayA.GetLength(0); i++)
    {
        for (int j = 0; j < arrayA.GetLength(1); j++)
        {
            multiArray[i, j] = arrayA[i, j] * arrayB[i, j];
        }
    }
    return multiArray;
}

int[,] firstArray = Fill2DArray(4, 4, 1, 5);
Print2DArray(firstArray);
int[,] secondArray = Fill2DArray(4, 4, 1, 5);
Console.WriteLine("");
Print2DArray(secondArray);
Console.WriteLine("");
bool test = TestArrays(firstArray, secondArray); // переходим к умножению, если массивы одинаковы по размеру, в обратном случае выводим ошибку
if (test == true)
{
    int[,] result = MultiplyArrays(firstArray, secondArray);
    Print2DArray(result);
}
else Console.WriteLine("Unable to multiply arrays");