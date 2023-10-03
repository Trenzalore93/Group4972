// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)




// наполняем массив случайными уникальными числами
int[,,] Fill3DArray(int param1, int param2, int param3, int min, int max)
{
    int x, index = 0;
    Random rnd = new Random();
    int[,,] array = new int[param1, param2, param3];
    int[] tempArray = new int[param1 * param2 * param3];
    for (int i = 0; i < param1; i++)
    {
        for (int j = 0; j < param2; j++)
        {
            for (int k = 0; k < param3;)
            {
                x = rnd.Next(min, max + 1);
                if (Array.IndexOf(tempArray, x) >= 0)
                    continue;
                tempArray[index++] = x;
                array[i, j, k++] = x;
            }
        }
    }
    return array;
}

// метод печати массива
void Print3DArray(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})\t");
            }
            Console.WriteLine("");
        }
    }
}

int[,,] array = Fill3DArray(2, 2, 2, 1, 10);
Print3DArray(array);

