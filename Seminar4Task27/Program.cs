// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// (задание со *) Сделать оценку времени алгоритма через вещественные числа и строки

int ReadNum(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int DigitSum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

int DigitSumString(int num)
{
    int result1 = 0;
    char[] array = num.ToString().ToCharArray();
    for (int i = 0; i < array.Length; i++)
    {
        result1 = result1 + array[i];
    }
    return result1;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadNum("Введите число: ");
DateTime d1 = DateTime.Now;
int sum = DigitSum(num);
Console.WriteLine(DateTime.Now-d1);
DateTime d2 = DateTime.Now;
int sumMethod2 = DigitSumString(num);
Console.WriteLine(DateTime.Now-d2);
PrintResult($"Метод 1: Сумма цифр в числе {num} равна {sum}.");
PrintResult($"Метод 2: Сумма цифр в числе {num} равна {sumMethod2}.");