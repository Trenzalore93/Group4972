// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void FibonacciToN(int num)
{
    int temp = 0;
    int first = 0;
    int second = 1;
    Console.Write($"{first} {second}");
    for (int i = 2; i < num; i++)
    {
        Console.Write($" {first + second}");
        temp = first + second;
        first = second;
        second = temp;
    }
}

int number = ReadData("Введите число: ");
FibonacciToN(number);