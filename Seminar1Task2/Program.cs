Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine() ?? "0");
int max = numA;
if (numB > numA)
{
    max = numB;
}
Console.WriteLine("Максимальное число: "+max);
