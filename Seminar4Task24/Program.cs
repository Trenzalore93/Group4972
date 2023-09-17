// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// Например:
// 7 -> 28
// 4 -> 10
// 8 -> 36

int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

int SumDigit(int numA)
{
    int result = 0;
    for (int i = 1; i <= numA; i++)
    {
        //result = result + i --> то же самое, что:
        result+=i;
    }
    return result;
}

int GausseSum(int numA)
{
    int sumOfDigits = 0;
    sumOfDigits = (numA*(numA+1))/2;
    return sumOfDigits;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numA = ReadData("Введите число: ");
DateTime d1 = DateTime.Now;
int sum = SumDigit(numA);
Console.WriteLine(DateTime.Now-d1);
DateTime d2 = DateTime.Now;
int sumGausse = GausseSum(numA);
Console.WriteLine(DateTime.Now-d2);
PrintResult("Сумма чисел от одного до "+numA+" (простой) равна " + sum);
PrintResult("Сумма чисел от одного до "+numA+" по Гауссу равна " + sumGausse);

