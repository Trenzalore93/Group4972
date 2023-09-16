// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
double Calc2DDistance(int numX1, int numY1, int numX2, int numY2)
{
    double result = Math.Sqrt((numX1-numX2)*(numX1-numX2)+(numY1-numY2)*(numY1-numY2));
    return result;
}
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numX1 = ReadData("Введите значение Х первой точки: ");
int numY1 = ReadData("Введите значение Y первой точки: ");
int numX2 = ReadData("Введите значение Х второй точки: ");
int numY2 = ReadData("Введите значение Y второй точки: ");
double distance = Calc2DDistance(numX1,numY1,numX2,numY2);
PrintResult("Расстояние между точками: "+distance);