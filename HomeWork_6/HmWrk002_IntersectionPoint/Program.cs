// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
// уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void IntersectionPoint(double[] result, double k1, double k2, double b1, double b2)
{    
    result[0] = (b2 - b1) / (k1 - k2);
    result[1] = result[0] * k1 + b1;       
}

try
{
    Console.Write("Введите число K1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число B1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число K2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите число B2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());

    if (k1 == k2 && b1 != b2) Console.WriteLine("Прямые паралельны.");
    else if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают.");
    else
    {
        double[] xyResult = new double[2];
        IntersectionPoint(xyResult, k1, k2, b1, b2);
        Console.WriteLine($"X: {xyResult[0]}");
        Console.WriteLine($"Y: {xyResult[1]}");
    }
}
catch
{
    Console.WriteLine("Введено некорректное значение.");
}
