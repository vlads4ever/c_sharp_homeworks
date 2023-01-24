// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.​
// Например, задан массив:​
// 1 4 7 2​
// 5 9 2 3​
// 8 4 2 4​
// 1 7 -> такого числа в массиве нет

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

int GetSpecifiedElement(int[,] matrix, int m, int n)
{
    return matrix[m, n];   
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int ROWS = 4;
const int COLUMNS = 7;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 9;

int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(resultMatrix);

try
{
    Console.Write("Введите номер строки: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите номер столбца: ");
    int n = Convert.ToInt32(Console.ReadLine());

    if (m > 0 && 
        m <= resultMatrix.GetLength(0) && 
        n > 0 && 
        n <= resultMatrix.GetLength(1))
    {
        int specElement = GetSpecifiedElement(resultMatrix, m - 1, n - 1);
        Console.WriteLine(specElement);
    }
    else
    {
        Console.WriteLine("Элемента, c указанными индексами, не существует.");
    }
}
catch 
{
    Console.WriteLine("Введено некорректное значение.");
}
    



