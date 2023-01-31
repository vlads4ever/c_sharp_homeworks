/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

void PrintNaturalNumbers(int n, int startNumber = 1)
{
    if (startNumber == n + 1) return;
    PrintNaturalNumbers(n, startNumber + 1);
    Console.Write(startNumber + " ");
}

const int NUMBER = 9;
PrintNaturalNumbers(NUMBER);