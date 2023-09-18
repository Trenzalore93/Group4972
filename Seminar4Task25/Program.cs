// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int ReadData(string msg) // метод для введения чисел с клавиатуры
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// double RaiseToPow(int numA, int numB) // возводим в степень
// {
//     double result = 0;
//     result = Math.Pow(numA, numB);
//     return result;
// }

// void PrintResult(string msg) // печатаем результат
// {
//     Console.WriteLine(msg);
// }

// int numA = ReadData("Введите число А: ");
// int numB = ReadData("Введите степень - число B: "); // ввели оба числа
// if (numB < 0) Console.WriteLine("Число B должно быть натуральным!"); // условие, чтобы проверить, является ли число B натуральным
// else // если да - возводим в степень и печатаем ответ
// {
//     double numAtoB = RaiseToPow(numA, numB);
//     PrintResult("Число А в степени B равно " + numAtoB);
// }



// ______________________________________________________________________________________ 
//(задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень    ||
//_______________________________________________________________________________________|

int ReadNum(string msg) // вводим числа с клавиатуры
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string ReadOperation(string msg) // вводим вид вычислений с клавиатуры (+, -, /, *, ^ (в степени))
{
    Console.WriteLine(msg);
    string operation = Console.ReadLine();
    return operation;
}

bool CheckOper(string operation) // проверяем введённый символ для операции 
{
    bool noOper = false;
    if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "^") noOper = false;
    else noOper = true;
    return noOper;    
}

double Calc(int numA, int numB, string operation) //метод для вычисления, исходя из введённого символа операции
{
    double result = 0;
    if (operation == "+") result = numA + numB;
    else if (operation == "-") result = numA - numB;
    else if (operation == "/") result = numA / numB;
    else if (operation == "*") result = numA * numB;
    else if (operation == "^") result = Math.Pow(numA, numB);
    return result;
}

void PrintResult(string msg) // метод для выведения результата
{
    Console.WriteLine(msg);
}

int numA = ReadNum("Введите число А: "); // ввели первое число
string operation = ReadOperation("Введите операцию: +, -, /, * или ^ (в степени)"); // ввели символ операции
int numB = ReadNum("Введите число B: "); // ввели второе число
if (CheckOper(operation) == true) PrintResult("Операция не найдена"); // используем проверку символа и выводим сообщение, если он не верен
{
    double result = Calc(numA, numB, operation); // если верен - выполняем операцию
    PrintResult($"{numA} {operation} {numB} = {result}");
}

//!!!!!! У меня почему-то с типом данных double не выводит дробные числа => 7 / 3 = 2.