// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

//получение данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//нахождение суммы натуральных чисел между M и N через рекурсию: достигаем значения N и останавливаемся:
int RecMNSum(int m, int n)
{
    if (m > n) return 0;
    else return m + RecMNSum(m + 1, n);
}

int numM = ReadData("Введите число M:");
int numN = ReadData("Введите число N:");
int result = RecMNSum(numM, numN);
Console.WriteLine($"Cумма натуральных элементов в промежутке от {numM} до {numN}: {result}");