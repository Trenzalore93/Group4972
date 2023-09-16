// Напишите программу, которая принимает на вход пятизначное число и проверяет,  является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
if (number > 99999 || number < 10000)
{
    Console.WriteLine("Число не пятизначное");
    return false;
}
else
{
    int digit1 = number / 10000;
    int digit2 = (number / 1000) % 10;
    int digit3 = (number / 10) % 10;
    int digit4 = number % 10;
    if (digit1 == digit4 && digit2 == digit3) ;
    {
        return true;
    }
    else
    {
        return false;
    }
}