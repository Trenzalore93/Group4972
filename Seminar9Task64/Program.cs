// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//получение данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

// формируем строку от N до 1 через рекурсию
string Rec1toN(int num)
{
    if (num==1) return "1";
    else return $"{num}, {Rec1toN(num-1)}";
}

int number = ReadData("Введите число N: ");
Console.WriteLine(Rec1toN(number));