// Задача 38: Задайте массив натуральных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }

    return array;
}

int GetMaxMinDifference (int[] array)
{    
    int arraySize = array.Length;
    int max = array[0];
    int min = array[0];    
    
    for (int i = 1; i < arraySize; i ++)
    {
        if (max < array[i]) max = array[i];
        if (min > array[i]) min = array[i];
    }    
    
    int diff = max - min;
    return diff;
}

const int LEFT = 1;
const int RIGHT = 99;

try
{
    Console.Write("Введите количество элементов массива не меньше двух: ");
    int count = Convert.ToInt32(Console.ReadLine());

    if (count >= 2)
    {
        int[] massive = GetRandomArray(count, LEFT, RIGHT);
        Console.WriteLine(string.Join(", ", massive));

        int maxMinDifference = GetMaxMinDifference(massive);
        Console.WriteLine(maxMinDifference);
    }
    else Console.WriteLine("Количество элементов должно быть не меньше двух.");
}
catch
{
    Console.WriteLine("Введено некорректное значение.");
}

