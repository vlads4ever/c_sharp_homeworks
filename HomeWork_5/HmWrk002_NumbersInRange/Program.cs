// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }

    return array;
}

int GetNumbersInRangeCount(int[] array, int lRange, int rRange)
{
    int count = 0;
    int arraySize = array.Length;   

    for (int i = 0; i < arraySize; i++)
    {
        if (array[i] >= lRange && array[i] <= rRange) count++;
    }    
    
    return count;
}

const int SIZE = 123;
const int LEFT = 0;
const int RIGHT = 150;
const int LRANGE = 10;
const int RRANGE = 99;

int[] massive = GetRandomArray(SIZE, LEFT, RIGHT);
Console.WriteLine(string.Join(", ", massive));

int numbersInRangeCount = GetNumbersInRangeCount(massive, LRANGE, RRANGE);
Console.WriteLine();
Console.WriteLine(numbersInRangeCount);
