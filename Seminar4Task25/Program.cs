// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


// int ReadData(string msg)
// {
//     Console.WriteLine(msg);
//     int num = int.Parse(Console.ReadLine() ?? "0");
//     return num;
// }

// decima RaiseToPow(int numA, int numB)
// {
//     decima result = 0;
//     result = Math.Pow(numA, numB);
//     return result;
// }

// void PrintResult(string msg)
// {
//     Console.WriteLine(msg);
// }

// int numA = ReadData("Введите число А: ");
// int numB = ReadData("Введите степень - число B: ");
// decima numAtoB = RaiseToPow(numA, numB);
// PrintResult("Число А в степени B равно "+numAtoB);


// ______________________________________________________________________________________ 
//(задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень    ||
//_______________________________________________________________________________________|

int ReadNum(string msg)
{
    Console.WriteLine(msg);
    int num = int.Parse(Console.ReadLine() ?? "0");
    return num;
}

string ReadOperation(string msg)
{
    Console.WriteLine(msg);
    string operation = Console.ReadLine();
    return operation;
}

bool CheckOper(string operation)
{
    bool noOper = false;
    if (operation == "+" || operation == "-" || operation == "*" || operation == "/" || operation == "в степени") noOper = false;
    else noOper = true;
    return noOper;    
}

double Calc(int numA, int numB, string operation)
{
    double result = 0;
    if (operation == "+") result = numA + numB;
    else if (operation == "-") result = numA - numB;
    else if (operation == "/") result = numA / numB;
    else if (operation == "*") result = numA * numB;
    else if (operation == "в степени") result = Math.Pow(numA, numB);
    return result;
}

void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

int numA = ReadNum("Введите число А: ");
string operation = ReadOperation("Введите операцию: +, -, /, * или в степени");
int numB = ReadNum("Введите число B: ");
if (CheckOper(operation) == true) PrintResult("Операция не найдена");
else
{
    double result = Calc(numA, numB, operation);
    PrintResult($"{numA} {operation} {numB} = {result}");
}
