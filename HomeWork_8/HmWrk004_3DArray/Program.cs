/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] GetThreeDArray(int x, int y, int z)
{
    int[,,] threeDArray = new int[x, y, z];
    int startValue = 10;

    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                threeDArray[i, j, k] = startValue;
                startValue++;
            }
        }
    }

    return threeDArray;
}

void PrintThreeDArray(int[,,] threeDArray)
{
    for (int i = 0; i < threeDArray.GetLength(0); i++)
    {
        for (int j = 0; j < threeDArray.GetLength(1); j++)
        {
            for (int k = 0; k < threeDArray.GetLength(2); k++)
            {
                Console.Write($"{threeDArray[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

const int X = 2;
const int Y = 2;
const int Z = 2;

int[,,] threeDArray = GetThreeDArray(X, Y, Z);
PrintThreeDArray(threeDArray);