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

int DigitSum (int num)
{
    
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}