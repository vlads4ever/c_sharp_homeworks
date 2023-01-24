// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] GetAverageInColumns(int[,] matrix)
{    
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    double[] averageMatrix = new double[columns];

    for (int j = 0; j < columns; j++)
    {
        double sumOfRow = 0;
        for (int i = 0; i < rows; i++)
        {
            sumOfRow += matrix[i, j];
        }
        averageMatrix[j] = Convert.ToDouble(sumOfRow) / rows;        
    }

    return averageMatrix;
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

void PrintArray(double[] array)
{    
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]:f1}; ");        
    }
}

const int ROWS = 7;
const int COLUMNS = 5;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 9;

int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(resultMatrix);

Console.WriteLine("=======================");
double[] averageArray = GetAverageInColumns(resultMatrix);
PrintArray(averageArray);
