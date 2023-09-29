// // Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, PrintListAvr и FindAverageInColumns.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на опрделенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) 
// и возвращает матрицу, удовлетворяющую этим условиям.


int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] array2D = new int[n, m];
    int temp = 1 - k;
    array2D[0, 0] = 0;
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            array2D[i, j] = temp + k;
            temp = array2D[i, j];
        }
    }
    return array2D;
}

// Метод PrintArray должен выводить на экран сгенерированную методом CreateIncreasingMatrix матрицу.

void PrintArray(int[,] matrix)
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

// Метод FindAverageInColumns принимает целочисленную матрицу типа int[,] и возвращает одномерный массив типа double. 
// Этот метод вычисляет среднее значение чисел в каждом столбце матрицы и сохраняет результаты в виде списка.

double[] FindAverageInColumns(int[,] matrix)
{
    double[] average = new double[matrix.GetLength(1)];
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j]; 
        }
        average[j] = sum / matrix.GetLength(1);
    }

    return average;
}

// Метод PrintListAvr принимает одномерный массив, возвращенный методом FindAverageInColumns и выводит этот список на экран в формате "The averages in columns are: x.x0 x.x0 x.x0 ...", 
// где x.x0 - это значения средних значений столбцов, округленные до двух знаков после запятой, разделенные знаком табуляции.

void PrintListAvr(double[] list)
{
    Console.Write("The averages in columns are:"+"\t");
    Console.WriteLine("");
    {
        for (int i = 0; i < list.Length; i++)
        {
            Console.Write(Math.Round(list[i], 2)+"\t");
        }
    }
}

int n = ReadData("Введите количество строк: ");
int m = ReadData("Введите количество столбцов: ");
int k = ReadData("Введите число, на которое увеличиваются значения: ");
int[,] array = CreateIncreasingMatrix(n, m, k);
PrintArray(array);
double[] result = FindAverageInColumns(array);
PrintListAvr(result);