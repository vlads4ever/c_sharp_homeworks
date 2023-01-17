// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }

    return array;
}

int GetUnevenPositionNumbersSum (int[] array)
{
    int sum = 0;
    int arraySize = array.Length;   
    // Будем брать нечетные позиции, а не индексы.
    for (int i = 0; i < arraySize; i += 2)
    {
        sum += array[i];
    }    
    
    return sum;
}

const int LEFT = 0;
const int RIGHT = 9;

try
{
    Console.Write("Введите количество элементов массива: ");
    int count = Convert.ToInt32(Console.ReadLine());

    if (count >= 1)
    {
        int[] massive = GetRandomArray(count, LEFT, RIGHT);
        Console.WriteLine(string.Join(", ", massive));

        int unevenPositionNumbersSum = GetUnevenPositionNumbersSum(massive);
        Console.WriteLine(unevenPositionNumbersSum);
    }
    else Console.WriteLine("Должен быть хотя бы один элемент.");

    
}
catch
{
    Console.WriteLine("Введено некорректное значение.");
}





