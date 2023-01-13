// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int InputNumber(string message)
{
    Console.Write(message);    
    int number = Convert.ToInt32(Console.ReadLine());
    return number;      
}

int MyPow(int numberA, int numberB)
{    
    int resultPow = numberA;

    if (numberA == 0 && numberB == 0)
    {
        return 0;
    }
    else if (numberA != 0 && numberB == 0)
    {
        return 1;
    }
    else
    {
        for (int i = 1; i < numberB; i++)
        {
            resultPow = resultPow * numberA;
        }
        return resultPow;
    }    
}

try
{
    int a = InputNumber("Введите целое число A: ");
    int b = InputNumber("Введите целое неотрицательное число B: ");

    if (b < 0)
    {
        Console.WriteLine("Введено отрицательное число B.");
    }
    else
    {
        int result = MyPow(a, b);
        Console.WriteLine(result);
    }
}
catch
{
    Console.WriteLine("Введено некорректное значение.");
}



