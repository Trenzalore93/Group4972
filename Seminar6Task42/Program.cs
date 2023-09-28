// Напишите программу, которая будет преобразовывать десятичное число в двоичное.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string DecToBin(int init)
{
    string line = string.Empty;
    while (init > 0)
    {
        line = init % 2 + line;
        init = init / 2;
    }
    return line;
}

int initial = ReadData("Введите число: ");
string result = DecToBin(initial);
Console.WriteLine($"Число в двоичном коде: {result}");