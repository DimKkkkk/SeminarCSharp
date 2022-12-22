/* Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

static void Dots_Coord(ref int x, ref int y, ref int z)
{
    try
    {
        Console.Write("Введите координату X : ");
        x = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите координату Y : ");
        y = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите координату Z : ");
        z = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}

int x1=0, y1=0, z1=0, x2=0, y2=0, z2=0; 

Dots_Coord(ref x1, ref y1, ref z1);
Dots_Coord(ref x2, ref y2, ref z2);

double result = Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2)+Math.Pow(z1-z2, 2));
Console.WriteLine($"X1 ({x1},{y1}); Y1 ({x2},{y2}; Z1 ({z1},{z2})) -> {Math.Round(result, 2)}"); //Math.Round округляет число результат.