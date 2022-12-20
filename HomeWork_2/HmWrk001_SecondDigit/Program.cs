// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и
// на выходе показывает вторую цифру этого числа.

Console.Write("Введите целое трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberABS = Math.Abs(number);

if ((numberABS < 100) || (numberABS > 999))
{
    Console.WriteLine("Вы ввели не трехзначное число.");
}
else
{
    int secondDigit = (numberABS / 10) % 10;
    Console.WriteLine($"Вторая цифра числа: {secondDigit}");
}