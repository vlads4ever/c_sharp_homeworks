/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int GetSumOfNaturalNumbers(int m, int n)
{    
    if (n == m - 1) return 0;
    return n + GetSumOfNaturalNumbers(m, n - 1);    
}

const int M = 4;
const int N = 8;

Console.WriteLine(GetSumOfNaturalNumbers(M, N));
