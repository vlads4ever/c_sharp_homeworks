/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9 */

int GetAkkermanFunction(int m, int n)
{
    if (m == 0) return n + 1;    
    if (m > 0 && n == 0) return GetAkkermanFunction(m - 1, 1);             
    return GetAkkermanFunction(m - 1, GetAkkermanFunction(m, n - 1));       
}

const int M = 3;
const int N = 8;

Console.WriteLine(GetAkkermanFunction(M, N));
