// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// int[] FillArray(int min, int max)
// {
//     int[] array = new int[8];
//     Random md = new Random();
//     for (int i = 0; i < 8; i++)
//     {
//         array[i] = md.Next(min, max+1);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ",");
//     }
//     Console.Write(array[array.Length - 1] + "]");
// }

// int min = ReadData("Введите минимальное значение в массиве: ");
// int max = ReadData("Введите максимальное значение в массиве: ");
// int[] array = FillArray(min, max);
// PrintArray(array);

//________________________________________________________________________________
//(задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов ||
//_______________________________________________________________________________||

// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// int[] FillArray(int min, int max, int length)
// {
//     int[] array = new int[length];
//     Random md = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = md.Next(min, max+1);
//     }
//     return array;
// }
// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ",");
//     }
//     Console.Write(array[array.Length - 1] + "]");
// }

// int min = ReadData("Введите минимальное значение в массиве: ");
// int max = ReadData("Введите максимальное значение в массиве: ");
// int length = ReadData("Введите длину массива: ");
// int[] array = FillArray(min, max, length);
// PrintArray(array);


//_____________________________________________________________________________________________
//Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал ||
// Игорь, Антон, Сергей -> Антон                                                              || 
//____________________________________________________________________________________________||

// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).

string ReadData(string msg)
{
    Console.WriteLine(msg);
    string phrase = Console.ReadLine();
    return phrase;
}

string ChooseName(string phrase)
{
    string result = String.Empty;
    string[] names = phrase.Split(',');
    int length = names.Length;
    int resultIndex = new Random().Next(0, length-1);
    result = names[resultIndex];
    return result;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

string phrase = ReadData("Введите имена через запятую: ");
string random = ChooseName(phrase);
PrintResult($"И победитель: {random}!!!");

