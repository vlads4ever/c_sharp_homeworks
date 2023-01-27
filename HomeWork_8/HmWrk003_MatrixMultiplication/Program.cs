﻿/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

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

int GetElement(int i, int j, int[,] firstMatrix, int[,] secondMatrix)
{
    int sum = 0;
    int count = firstMatrix.GetLength(1);

    for (int k = 0; k < count; k++)
    {       
        sum += firstMatrix[i, k] * secondMatrix[k, j];
    }

    return sum;
}

int[,] GetMatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int rowsCount = 0;
    if (firstMatrix.GetLength(0) < secondMatrix.GetLength(0)) rowsCount = firstMatrix.GetLength(0);
    else rowsCount = secondMatrix.GetLength(0);

    int colsCount = 0;
    if (firstMatrix.GetLength(1) < secondMatrix.GetLength(1)) rowsCount = firstMatrix.GetLength(1);
    else rowsCount = secondMatrix.GetLength(1);

    int[,] resultMatrix = new int[rowsCount, colsCount];
    
    for (int i = 0; i < rowsCount; i++)
    {        
        for (int j = 0; j < colsCount; j++)
        {
            resultMatrix[i, j] = GetElement(i, j, firstMatrix, secondMatrix); 
        }        
    }

    return resultMatrix;     
}


const int FIRST_ROWS = 3;
const int FIRST_COLUMNS = 3;
const int SECOND_ROWS = 3;
const int SECOND_COLUMNS = 2;
const int LEFT_RANGE = 0;
const int RIGHT_RANGE = 10;

if (FIRST_COLUMNS == SECOND_ROWS)
{
    int[,] firstMatrix = GetRandomMatrix(FIRST_ROWS, FIRST_COLUMNS, LEFT_RANGE, RIGHT_RANGE);
    int[,] secondMatrix = GetRandomMatrix(SECOND_ROWS, SECOND_COLUMNS, LEFT_RANGE, RIGHT_RANGE);
    PrintMatrix(firstMatrix);
    Console.WriteLine("****************************");
    PrintMatrix(secondMatrix);
    int[,] multiplMatrix = GetMatrixMultiplication(firstMatrix, secondMatrix);
    Console.WriteLine("============================");
    PrintMatrix(multiplMatrix);
}
else
{
    Console.WriteLine("Матрицы нельзя перемножить.");
    Console.WriteLine("Колличество столбцов первой матрицы не равно количеству строк второй матрицы.");
} 


