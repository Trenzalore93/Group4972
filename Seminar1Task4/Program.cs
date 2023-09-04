// Задача №5
// Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.
Console.WriteLine("Введите число: ");
int numN = int.Parse(Console.ReadLine() ?? "0");
int negNumN = (-1) * numN;
while (negNumN < numN)
{
    Console.Write(negNumN + ", ");
    negNumN++;
}
Console.WriteLine(numN);

// int a = int.Parse(Console.ReadLine());
// if (a < 0) a = -a;
// for(int i = -a; i <= a; i++){
//    Console.Write(i);
//    Console.Write(" ");
// }