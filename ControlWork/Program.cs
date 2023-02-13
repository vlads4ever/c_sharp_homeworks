﻿/* Контрольная задача:

Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше
либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения
алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно
массивами.

Примеры:
["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["Russia", "Kazan", "Denmark"] -> []
 */

int GetThreeSymbolCount(string[] textArray)
{
    int count = 0;
    for (int i = 0; i < textArray.Length; i++)
    {
        if (textArray[i].Length <= 3) count ++;
    }

    return count;
}

string[] GetThreeSymbolArray(string[] textArray, int count)
{    
    string[] threeSymbolArray = new string[count];
    int j = 0;
    for (int i = 0; i < textArray.Length; i++)
    {
        if (textArray[i].Length <= 3) threeSymbolArray[j++] = textArray[i];
    }

    return threeSymbolArray;
}

void PrintArray(string[] textArray)
{
    for (int i = 0; i < textArray.Length; i++)
    {
        if (i != textArray.Length - 1)
        {
            Console.Write($"{textArray[i]}, ");
        }
        else Console.WriteLine(textArray[i]);        
    }
}

string[] startArray = {":-)", "Hello", "world", "!", "Bob", "final"};

Console.WriteLine();
Console.WriteLine("This is start array:");
PrintArray(startArray);

int countSymbol = GetThreeSymbolCount(startArray);
string[] finalArray = GetThreeSymbolArray(startArray, countSymbol);

Console.WriteLine("============================");
Console.WriteLine("This is final array:");
PrintArray(finalArray);

