// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// int ReadData(string msg) // получаем значение
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// int[] FillArray(int min, int max) // заполняем массив случайными значениями от min до max+1
// {
//     int[] array = new int[8];
//     Random md = new Random();
//     for (int i = 0; i < 8; i++)
//     {
//         array[i] = md.Next(min, max+1);
//     }
//     return array;
// }
// void PrintArray(int[] array) // выводим массив
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ",");
//     }
//     Console.Write(array[array.Length - 1] + "]");
// }

// int min = ReadData("Введите минимальное значение в массиве: "); // получаем минимальное значение
// int max = ReadData("Введите максимальное значение в массиве: "); // получаем максимальное значение
// int[] array = FillArray(min, max); // заполняем
// PrintArray(array); // выводим

//________________________________________________________________________________
//(задание со *) Ввести с клавиатуры длину массива и диапазон значений элементов ||
//_______________________________________________________________________________||

// int ReadData(string msg) //получаем числовое значение
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }
// int[] FillArray(int min, int max, int length) //заполняем массив случайными значениями от min до max+1 с длиной length
// {
//     int[] array = new int[length];
//     Random md = new Random();
//     for (int i = 0; i < length; i++)
//     {
//         array[i] = md.Next(min, max+1);
//     }
//     return array;
// }
// void PrintArray(int[] array) //выводим массив 
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         Console.Write(array[i] + ",");
//     }
//     Console.Write(array[array.Length - 1] + "]");
// }

// int min = ReadData("Введите минимальное значение в массиве: "); //вводим min
// int max = ReadData("Введите максимальное значение в массиве: ");// вводим max
// int length = ReadData("Введите длину массива: "); // вводим длину
// int[] array = FillArray(min, max, length); // заполняем
// PrintArray(array); // выводим


//_____________________________________________________________________________________________
//Написать программу которая из имен через запятую выберет случайное имя и выведет в терминал ||
// Игорь, Антон, Сергей -> Антон                                                              || 
//____________________________________________________________________________________________||

// Подсказка: Для разбора строки использовать метод string.split(). Для выбора случайного имени метод Random.Next(1,<длина массива имен>+1).

string ReadData(string msg) //получаем строку
{
    Console.WriteLine(msg);
    string phrase = Console.ReadLine();
    return phrase;
}

string ChooseName(string phrase) //разбиваем строку в массив, выбираем случайный индекс и присваиваем result значение этого случайного индекса
{
    string result = String.Empty;
    string[] names = phrase.Split(',');
    int length = names.Length;
    int resultIndex = new Random().Next(0, length-1);
    result = names[resultIndex];
    return result;
}

void PrintResult(string msg) //выводим имя
{
    Console.WriteLine(msg);
}

string phrase = ReadData("Введите имена через запятую: "); //получаем имена через запятую
string random = ChooseName(phrase); //выбираем случайное имя
PrintResult($"И победитель: {random}!!!"); //выводим случайное имя

