// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}
string FindSquares(int num, int pow)
{
    string result = String.Empty;
    for (int i = 1; i <= num; i++)
    {
        result = result + Math.Pow(i, pow) + " ";
    }
    return result;
}
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}
int num=ReadData("Введите число: ");
string original = FindSquares(num, 1);
PrintResult(original);
string squares = FindSquares(num, 2);
PrintResult(squares);