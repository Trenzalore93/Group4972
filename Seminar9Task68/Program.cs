// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


//получение данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

//записываем метол для функции Аккермана используя рекурсию
int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0 && m > 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

int numM = ReadData("Введите число M:");
int numN = ReadData("Введите число N:");
int result = Ackermann(numM, numN);
Console.WriteLine($"A({numM},{numN}) = {result}");