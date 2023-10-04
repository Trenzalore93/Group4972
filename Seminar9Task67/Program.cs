// Программа принимает на вход число N и возвращает сумму цифр в числе

//получение данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int SumDigitRec(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumDigitRec(num / 10);
}

int number = ReadData("Введите число: ");
int result = SumDigitRec(number);
Console.WriteLine($"Сумма цифр в числе: {result}");