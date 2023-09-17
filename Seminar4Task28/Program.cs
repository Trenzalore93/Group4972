// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

long Factorial(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        result = result * i;
    }
    return result;
}


void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int num = ReadData("Введите число: ");
long multi = Factorial(num);
PrintResult("Произведение чисел от 1 до "+num+" равно "+multi);