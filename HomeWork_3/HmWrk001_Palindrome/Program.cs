// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите целое пятизначное положительное число: ");
string number = Console.ReadLine();

if (number.Length < 1)
{
    Console.WriteLine("Вы не ввели ничего.");
    return;
}

if (number[0] == '-')
{
    Console.WriteLine("Число не может быть отрицательным.");
    return;
}

if (number.Length != 5)
{
    Console.WriteLine("Введенное число не соответствует требованиям задачи.");
    return;
}

bool palindromeFlag = true;             // Вводим переменную флаг для признака полиндрома
int indexLast = number.Length - 1;      // Вычисляем индекс последней "цифры" в строке

for (int i = 0; i <= indexLast; i++)
{    
    if (number[i] == number[indexLast - i])
    {
        palindromeFlag = true;
    }
    else
    {
        palindromeFlag = false;
        break;
    }
}

if (palindromeFlag == true)
{
    Console.WriteLine($"Число {number} является палиндромом.");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом.");
}