// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int InputNumber(string message)
{    
    Console.Write(message);    
    int outputNumber = Convert.ToInt32(Console.ReadLine());
    return outputNumber;         
}

int SumOfDigits(int num)
{
    int sum = 0;
    num = Math.Abs(num);
    
    while (num != 0)
    {
        sum += num % 10;
        num = num / 10;
    }

    return sum;
}

try
{
    int number = InputNumber(message: "Введите целое число: ");    
    int sum = SumOfDigits(number);
    Console.WriteLine(sum);
}
catch
{
    Console.WriteLine("Введено некорректное значение.");
}

