// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
// (задание со *) Сделать оценку времени алгоритма через вещественные числа и строки

int ReadNum(string msg) // получаем число с клавиатуры
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int DigitSum(int num) // вычисляем сумму цифр методом1 - %10
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

int DigitSumString(int num) // вычисляем сумму цифр методом2 - с помощью массива
{
    int result1 = 0;
    char[] array = num.ToString().ToCharArray();
    for (int i = 0; i < array.Length; i++)
    {
        result1 = result1 + array[i];
    }
    return result1;
}

void PrintResult(string msg) // выводим результат
{
    Console.WriteLine(msg);
}

int num = ReadNum("Введите число: "); // получаем число
DateTime d1 = DateTime.Now; // проверка скорости метода 1
int sum = DigitSum(num); // вычисление - метод 1
Console.WriteLine(DateTime.Now-d1); // проверка скорости метода 1
DateTime d2 = DateTime.Now; // проверка скорости метода 2
int sumMethod2 = DigitSumString(num); // вычисление - метод 2
Console.WriteLine(DateTime.Now-d2); // проверка скорости метода 2
PrintResult($"Метод 1: Сумма цифр в числе {num} равна {sum}."); // вывод
PrintResult($"Метод 2: Сумма цифр в числе {num} равна {sumMethod2}.");

// Введите число: 
// 123456789
// 00:00:00.0047367
// 00:00:00.0001362
// Метод 1: Сумма цифр в числе 123456789 равна 45. 
// Метод 2: Сумма цифр в числе 123456789 равна 477.
// ВЫВОД: Метод с массивом гораздо продуктивнее!!