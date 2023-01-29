/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */


int[,] GetSpiralRandomMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int startRowIndex = 0;
    int endRowIndex = rows - 1;
    int startColIndex = 0;
    int endColIndex = columns - 1;
    int value = 1;

    while (true)
    {       
        // Заполняем круг
        for (int j = startColIndex; j <= endColIndex; j++)
        {            
            matrix[startRowIndex, j] = value++;            
        }
        startRowIndex++;
        
        for (int i = startRowIndex; i <= endRowIndex; i++)
        {            
            matrix[i, endColIndex] = value++;            
        }
        endColIndex--;
        
        if (endColIndex >= startColIndex)
        {
            for (int j = endColIndex; j >= startColIndex; j--)
            {            
                matrix[endRowIndex, j] = value++;            
            }
            endRowIndex--;
        }        
        else break;

        if (endRowIndex >= startRowIndex)
        {
           for (int i = endRowIndex; i >= startRowIndex; i--)
            {            
                matrix[i, startColIndex] = value++;            
            }
            startColIndex++; 
        }
        else break;        
    }

    return matrix;
}

void SpecialPrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i,j] < 10) Console.Write("0" + matrix[i, j] + " ");
            else Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int ROWS = 4;
const int COLUMNS = 4;

int[,] spiralMatrix = GetSpiralRandomMatrix(ROWS, COLUMNS);
SpecialPrintMatrix(spiralMatrix);