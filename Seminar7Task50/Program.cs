// // Внутри класса Answer напишите методы CreateIncreasingMatrix, PrintArray, FindNumberByPosition и PrintCheckIfError.







// Метод CreateIncreasingMatrix должен создавать матрицу заданной размерности, с каждым новым элементом увеличивающимся на опрделенное число. 
// Метод принимает на вход три числа (n - количество строк матрицы, m - количество столбцов матрицы, k - число, на которое увеличивается каждый новый элемент) и возвращает матрицу, 
// удовлетворяющую этим условиям.
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

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// Метод FindNumberByPosition принимает на вход сгенрированную матрицу и числа x и y - позиции элемента в матрице. 
// Если указанные координаты находятся за пределами границ массива, метод должен вернуть массив с нулевым значением. 
// Если координаты находятся в пределах границ, метод должен вернуть массив с двумя значениями: значением числа в указанной позиции, 
// а второй элемент должен быть равен 0, чтобы показать, что операция прошла успешно без ошибок.

int[] FindNumberByPosition(int[,] array, int x, int y)
{
    int[] result = new int[0,1000];
    if (x > array.GetLength(0) - 1 || y > array.GetLength(1)) return null;
    else
    {
        int[] result = { array[x - 1, y - 1], 0 };
        return result;
    }
}

// Метод PrintCheckIfError должен принимать результат метода FindNumberByPosition и числа x и y - позиции элемента в матрице. 
// Метод должен проверить, был ли найден элемент в матрице по указанным координатам (x и y), используя результаты из метода FindNumberByPosition. 
// Если такого элемента нет, вывести на экран "There is no such index". Если элемент есть, вывести на экран "The number in [{x}, {y}] is {значение}".

void PrintCheckIfError(int[] result, int x, int y)
{
    if(result == null) Console.WriteLine("There is no such index");
    else Console.WriteLine($"The number in [{x}, {y}] is {result[0]}");
}


int n = ReadData("Введите количество строк: ");
int m = ReadData("Введите количество столбцов: ");
int k = ReadData("Введите число, на которое увеличиваются значения: ");
int[,] array = CreateIncreasingMatrix(n, m, k);
Print2DArray(array);
int x = ReadData("Введите x: ");
int y = ReadData("Введите y: ");
int[] result = FindNumberByPosition(array, x, y);
PrintCheckIfError(result, x, y);
