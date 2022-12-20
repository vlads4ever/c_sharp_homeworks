// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
// сообщает, что третьей цифры нет.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int numberABS = Math.Abs(number);

if (numberABS < 100)                // Если число двузначное или меньше
{
    Console.WriteLine("Во введенном числе нет третьей цифры.");
}
else if (numberABS < 1000)          // Если число трехзначное, но не двузначное
{
    int thirdDigit = numberABS % 10;
    Console.WriteLine($"Третья цифра числа: {thirdDigit}");
}
else                                // Если число содержит больше трех разрядов
{
    int reduction = numberABS;      // Вводим вспомогательную переменную для сокращения разрядности числа
    bool numberDigitFlag = true;    // Вводим переменную-флаг для завершения цикла
    int thirdDigit = 0;             // Объявляем переменную для последующего вывода

    while (numberDigitFlag)
    {
        reduction = reduction / 10; // Сокращаем разрядность на один      

        if (reduction < 1000)       // Проверяем, не сократилось ли число разрядов до трех
        {
            numberDigitFlag = false;
            thirdDigit = reduction % 10;            
        }        
    }
    Console.WriteLine($"Третья цифра числа: {thirdDigit}");    
}
