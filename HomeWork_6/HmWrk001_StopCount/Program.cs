// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
// ввёл пользователь. Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится 
// при помощи нажатия Enter.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

string UsersInput(int index)
{
    Console.Write($"Введите {index}-е число: ");
    string input = Console.ReadLine();
    return input;    
}

Console.WriteLine("Вводите целые числа. Чтобы закончить вводить числа наберите 'stop'.");
int countPositiveNumbers = 0;
int index = 1;
bool run = true;

// Будем крутить цикл до тех пор, пока не будет введено "stop"
while (run)
{
    string input = UsersInput(index);
    bool isNumber = int.TryParse(input, out int inputNumber);
    if (isNumber && inputNumber > 0) 
    {
        countPositiveNumbers++;
        index++;
    }
    else if (isNumber && inputNumber <= 0)
    {
        index++;
    }
    else if (isNumber == false && input == "stop")
    {
        Console.WriteLine(countPositiveNumbers);
        break;
    }
    else Console.WriteLine("Введено некоректное значение.");
}
