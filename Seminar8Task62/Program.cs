// . Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04  
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//получение данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
//честно нашла решение на гитхабе (пыталась то же самое сделать через for - вышло слишком громоздко): 
//заполняем спирально массив, чтобы шло заполнение следующим образом: 0,0 0,1 0,2 0,3 -> 1,3 2,3 3,3 -> 3,2 3,1 3,0 -> 2,0 1,0 -> 1,1 1,2 -> 2,2 2,1 
int[,] SpiralFill2DArray(int row, int column)
{
    int[,] array2D = new int[row, column];
    int temp = 1;
    int i = 0;
    int j = 0;
    while (temp <= array2D.GetLength(0) * array2D.GetLength(1))  //идём до тех пор, пока не достигнем 16 - максимального количества значений
    {
        array2D[i, j] = temp; 
        temp++;
        if (i <= j + 1 && i + j < array2D.GetLength(1) - 1)  //идём по столбцам первой строки (индекс строки меньше или равно индексу столбца и сумма значений индексов ниже 3)
            j++;
        else if (i < j && i + j >= array2D.GetLength(0) - 1) //идём вниз по строкам (индекс строки меньше столбца и сумма значений индексов выше 3)
            i++;
        else if (i >= j && i + j > array2D.GetLength(1) - 1) //идём по столбцам нижней строки (индекс строки больше индекса столбца и сумма значений индексов больше 3)
            j--;
        else
            i--;
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

int row = ReadData("Введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
if(row==column) 
{
    int[,] matrix = SpiralFill2DArray(row,column);
    Print2DArray(matrix);
}
else Console.WriteLine("Массив не образует квадрат.");
