// Задача 4: Напишите программу, которая принимает на вход три числа и 
// выдаёт максимальное из этих чисел.

Console.Write("Введите первое целое число: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье целое число: ");
int thirdNumber = Convert.ToInt32(Console.ReadLine());

if ((firstNumber == secondNumber) & (firstNumber == thirdNumber))
{
    Console.WriteLine("Сравниваемые числа равны.");
}
else
{
   int maxNumber = firstNumber;          //Предпологаем, что первое число максимальное

    if (maxNumber < secondNumber)
    {
        maxNumber = secondNumber;
    }
    
    if (maxNumber < thirdNumber)
    {
        maxNumber = thirdNumber;
    }
    
    Console.WriteLine($"Максимальное число: {maxNumber}"); 
}
