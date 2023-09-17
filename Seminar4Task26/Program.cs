// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// Пример:
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int GetNumberLength(int num)
{
    int count = 0;
    while (num > 0)
    {
        count++;
        num = num/10;
    }
    return count;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите число: ");
int result = GetNumberLength(num);
PrintResult("Число цифр в числе: "+result);