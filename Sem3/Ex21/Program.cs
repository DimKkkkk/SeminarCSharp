/* Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21 */

Console.Clear();
Console.Write("Введите координату точки X1: ");
int X1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координату точки Y1: ");
int Y1 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координату точки X2: ");
int X2 = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите координату точки Y2: ");
int Y2 = int.Parse(Console.ReadLine() ?? "");

double result = Math.Sqrt(Math.Pow(X1-X2, 2)+Math.Pow(Y1-Y2, 2));
Console.WriteLine($"X1 ({X1},{Y1}); Y1 ({X2},{Y2}) -> {Math.Round(result, 3)}"); //Math.Round округляет число результат.
