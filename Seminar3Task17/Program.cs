// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
// Например:
// x=34; y=-30 -> 4
// x=2; y=4-> 1
// x=-34; y=-30 -> 3

// Console.WriteLine("Введите x: ");
// int numX = int.Parse(Console.ReadLine() ?? "0");
// Console.WriteLine("Введите y: ");
// int numY = int.Parse(Console.ReadLine() ?? "0");

// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
// По координатам точки ищем четверть
int QuarterTest(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
// Выводим результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int x = ReadData("Введите координату x: ");
int y = ReadData("Введите координату y: ");
int result = QuarterTest(x, y);
PrintResult("Точка находится в четверти № "+result);