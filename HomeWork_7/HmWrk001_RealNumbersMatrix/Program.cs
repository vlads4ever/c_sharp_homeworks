﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.​
// m = 3, n = 4.​
// 0,5 7 -2 -0,2​
// 1 -3,3 8 -9,9​
// 8 7,8 -7,1 9

double[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    double[,] matrix = new double[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().NextDouble() * new Random().Next(leftRange, rightRange + 1);
        }
    }

    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f1} ");
        }
        Console.WriteLine();
    }
}

const int ROWS = 4;
const int COLUMNS = 7;
const int LEFT_RANGE = 5;
const int RIGHT_RANGE = 10;

double[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(resultMatrix);