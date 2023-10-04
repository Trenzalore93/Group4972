// Напишите прграмму, которая будет принимать 2 числа А и В, возведите А в степень В с помощью рекурсии

//получение данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long RecPow(int a, int b)
{
    long result = 1;
    if (b <= 0) return 1;
    else
    {
        result = a * RecPow(a, b - 1);
    }
    return result;
}

long MyPow(int a, int b)
{
    if (b == 2) return a * a;
    if (b == 1) return a;

    if (b % 2 == 0)
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2);
    }
    else
    {
        return MyPow(a, b / 2) * MyPow(a, b / 2 + 1);
    }
}

int numberA = ReadData("Введите число: ");
int numberB = ReadData("Введите число: ");
long result = RecPow(numberA, numberB);
long result1 = MyPow(numberA,numberB);
Console.WriteLine(result);
Console.WriteLine(result1);