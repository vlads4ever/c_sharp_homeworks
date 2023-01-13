// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их
// на экран. Данные вводятся с консоли пользователем

string[] NewArray(int size)
{
    return new string[size];
}

string InputElement(int index)
{
    Console.Write($"Введите {index + 1}-й элемент: ");    
    string element = Console.ReadLine();    
    return element;      
}

void FillArray(string[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        arr[i] = InputElement(i);        
    }
}


string[] array = NewArray(8);
FillArray(array);
Console.WriteLine(string.Join(" ", array));