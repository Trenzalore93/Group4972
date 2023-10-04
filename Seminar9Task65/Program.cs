//  Задайте значения M и N. Напишите программу, которая найдёт все натуральные элементы в промежутке от M до N.

//получение данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string RecMN(int m, int n)
{
    return n >= m ? $"{m} " + RecMN(m + 1, n) : "";
}

int numM = ReadData("Введите число M:");
int numN = ReadData("Введите число N:");
string elements = RecMN(numM, numN);
Console.WriteLine((numM>numN)?RecMN(numN, numM):RecMN(numM, numN));