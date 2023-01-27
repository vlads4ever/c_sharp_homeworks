﻿/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

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

void DescendingSort(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int index = 0;      

        while (index < matrix.GetLength(1))
        {
            for (int j = index + 1; j < matrix.GetLength(1); j++)
            {
                if (matrix[i, j] > matrix[i, index])
                {
                    (matrix[i, j], matrix[i, index]) = (matrix[i, index], matrix[i, j]);
                }
            }
            index++;
        }        
    }     
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
const int RIGHT_RANGE = 10;

int[,] resultMatrix = GetRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(resultMatrix);
DescendingSort(resultMatrix);
Console.WriteLine("============================");
PrintMatrix(resultMatrix);
