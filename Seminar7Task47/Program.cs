// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размеренность массива), 
// а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.
// Также, задайте метод PrintArray, который выводил бы массив на экран

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

double[,] CreateRandomMatrix(int m, int n, int minLimitRandom, int maxLimitRandom)
{
    Random rand = new Random();
    double[,] array2D = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array2D[i, j] = Math.Round(rand.Next(-100, 101)*0.1, 1);
        }
    }
    return array2D;
}

void Print2DArray(double[,] matrix)
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

int row = ReadData("введите количество строк: ");
int column = ReadData("Введите количество столбцов: ");
double[,] arr2D = CreateRandomMatrix(row, column, -10, 10);
Print2DArray(arr2D);