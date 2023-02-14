/* Контрольная задача:

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

string[] GetThreeSymbolArrayOverList(string[] textArray)
{    
    List<string> threeSymbolList = new List<string>();    
    for (int i = 0; i < textArray.Length; i++)
    {
        if (textArray[i].Length <= 3) threeSymbolList.Add(textArray[i]);        
    }

    return threeSymbolList.ToArray();
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

// Задаем исходный массив
string[] startArray = {":-)", "Hello", "world", "!", "Bob", "final"};

// Демонстрируем в консоли все элементы исходного массива
Console.WriteLine();
Console.WriteLine("This is start array:");
PrintArray(startArray);


// Первый способ:
// Инициализируем и наполняем "подходящими" элементами новый массив
// (при этом способе не требуется находить длину массива)
string[] firstFinalArray = GetThreeSymbolArrayOverList(startArray);


// Второй способ:
// Получаем количество удовлетворяющих условию элементов в исходном массиве
int countSymbol = GetThreeSymbolCount(startArray);
// Инициализируем и наполняем "подходящими" элементами новый массив
string[] secondFinalArray = GetThreeSymbolArray(startArray, countSymbol);



// Организуем вывод элементов результирующего массива, полученного через список
Console.WriteLine("============================");
Console.WriteLine("This is final array over list:");
PrintArray(firstFinalArray);

// Организуем вывод элементов результирующего массива, полученного двумя циклами
Console.WriteLine("============================");
Console.WriteLine("This is second final array over two cycles:");
PrintArray(secondFinalArray);
