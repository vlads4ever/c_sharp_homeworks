// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }

    return array;
}

int GetEvenNumbersCount (int[] array)
{
    int count = 0;
    int arraySize = array.Length;   

    for (int i = 0; i < arraySize; i++)
    {
        if (array[i] % 2 == 0) count++;
    }    
    
    return count;
}

const int LEFT = 100;
const int RIGHT = 999;

try
{
    Console.Write("Введите количество элементов массива: ");
    int count = Convert.ToInt32(Console.ReadLine());

    if (count >= 1)
    {
        int[] massive = GetRandomArray(count, LEFT, RIGHT);
        Console.WriteLine(string.Join(", ", massive));

        int evenNumbersCount = GetEvenNumbersCount(massive);
        Console.WriteLine(evenNumbersCount);
    }
    else Console.WriteLine("Должен быть хотя бы один элемент.");

    
}
catch
{
    Console.WriteLine("Введено некорректное значение.");
}

