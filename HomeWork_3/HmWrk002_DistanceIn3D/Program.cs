// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.

Console.Write("Введите значение X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2)) + Math.Pow((z2 - z1), 2);
Console.WriteLine($"Расстояние между двумя точками = {Math.Round(result, 2)}.");
