
//получение данных от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

void GetLineRec(int n)
{
    Console.Write(n + " ");
    if (n <= 1)
    {

    }
    else GetLineRec(n - 1);
}

int num = ReadData("Введите число: ");
GetLineRec(num);