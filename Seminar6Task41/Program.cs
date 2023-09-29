// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
// (Задание со звездочкой) Пользователь вводит число нажатий, затем программа следит за нажатиями и выдает сколько чисел больше 0 было введено.

// получение значений и перевод их в массив
int[] ReadData(string msg)
{
    Console.WriteLine(msg);
    string initial = Console.ReadLine();
    int[] numbers = initial.Split(',').Select(int.Parse).ToArray();
    return numbers;
}

void PrintArray(int[] array) // выводим массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine("");
}

// считаем количество значений выше 0
int PositivityCheck(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int[] array = ReadData("Введите числа через запятую: ");
PrintArray(array);
int result = PositivityCheck(array);
Console.WriteLine($"Количество чисел больше нуля - {result}");

