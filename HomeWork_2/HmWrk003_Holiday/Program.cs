// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели: ");
int dayOfTheWeek = Convert.ToInt32(Console.ReadLine());

if ((dayOfTheWeek < 1) || (dayOfTheWeek > 7))
{
    Console.WriteLine("Введенное число не соответствует ни одному дню недели.");
}
else
{
    if (dayOfTheWeek > 5)
    {
        Console.WriteLine($"{dayOfTheWeek}-й день недели выходной.");
    }
    else
    {
        Console.WriteLine($"{dayOfTheWeek}-й день недели будний.");
    }
}