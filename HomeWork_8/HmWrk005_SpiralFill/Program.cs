/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int[,] GetSpiralRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];
    int startRowIndex = 0;
    int endRowIndex = rows - 1;
    int startColIndex = 0;
    int endColIndex = columns - 1;
        
    while (true)
    {       
        // Заполняем круг
        for (int j = startColIndex; j <= endColIndex; j++)
        {            
            matrix[startRowIndex, j] = new Random().Next(leftRange, rightRange + 1);            
        }
        startRowIndex++;
        
        for (int i = startRowIndex; i <= endRowIndex; i++)
        {            
            matrix[i, endColIndex] = new Random().Next(leftRange, rightRange + 1);            
        }
        endColIndex--;
        
        if (endColIndex >= startColIndex)
        {
            for (int j = endColIndex; j >= startColIndex; j--)
            {            
                matrix[endRowIndex, j] = new Random().Next(leftRange, rightRange + 1);            
            }
            endRowIndex--;
        }        
        else break;

        if (endRowIndex >= startRowIndex)
        {
           for (int i = endRowIndex; i >= startRowIndex; i--)
            {            
                matrix[i, startColIndex] = new Random().Next(leftRange, rightRange + 1);            
            }
            startColIndex++; 
        }
        else break;        
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

const int ROWS = 5;
const int COLUMNS = 3;
const int LEFT_RANGE = 1;
const int RIGHT_RANGE = 9;

int[,] spiralMatrix = GetSpiralRandomMatrix(ROWS, COLUMNS, LEFT_RANGE, RIGHT_RANGE);
PrintMatrix(spiralMatrix);