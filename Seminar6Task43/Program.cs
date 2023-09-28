// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double ReadData(string msg)
{
    Console.WriteLine(msg);
    double num = double.Parse(Console.ReadLine() ?? "0");
    return num;
}

void FindIntersectionPoint(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Прямые параллельны и не пересекаются.");
    else
    {
        double x = 0;
        double y = 0;
        x = (b2 - b1) / (k1 - k2);
        y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения прямых имеет координаты: x = {x}, y = {y}");
    }
}

double b1 = ReadData("Введите значение b1: ");
double k1 = ReadData("Введите значение k1: ");
double b2 = ReadData("Введите значение b2: ");
double k2 = ReadData("Введите значение k2: ");
FindIntersectionPoint(b1, k1, b2, k2);