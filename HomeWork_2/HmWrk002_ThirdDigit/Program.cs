// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberABS = Math.Abs(number);

if (numberABS < 100)
{
    Console.WriteLine("Во введенном числе нет третьей цифры.");
}
else if (numberABS < 1000)
{
    int thirdDigit = numberABS % 10;
    Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}
else
{
    int reduction = numberABS;
    bool numberDigitFlag = true;
    int thirdDigit = 0;   

    while (numberDigitFlag)
    {
        reduction = reduction / 10;        

        if (reduction < 1000) 
        {
            numberDigitFlag = false;
            thirdDigit = reduction % 10;            
        }        
    }
    Console.WriteLine($"Третья цифра числа: {thirdDigit}");    
}
