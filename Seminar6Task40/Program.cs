// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

bool TriangleTest(int a, int b, int c)
{
    // bool result = true;
    // if (a + b < c) result = false;
    // if (b + c < a) result = false;
    // if (a + c < b) result = false;
    return ((a + b > c) && (b + c > a) && (a + c > b));
}

void PrintResult(bool result)
{
    if (result == true) Console.WriteLine("Это треугольник");
    else Console.WriteLine("Это НЕ треугольник");
}

int a = ReadData("Введите длину первой стороны: ");
int b = ReadData("Введите длину второй стороны: ");
int c = ReadData("Введите длину третьей стороны: ");
bool isTriangle = TriangleTest(a, b, c);
PrintResult(isTriangle);
