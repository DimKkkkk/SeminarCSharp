/* Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y). */

static int InitQuaterByUser()
{
    try
    {
        Console.Write("Введите Номер координатной четверти: ");
        int x=int.Parse(Console.ReadLine() ?? "");
        return x;
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return 0;
    }
}

static void PrintQuarterByCoords(int x)
{
    if(x==1)
        Console.WriteLine("x>0 и y>0");
    else if(x ==2)
        Console.WriteLine("x<0 и y>0");
    else if(x ==3)
        Console.WriteLine("x<0 и y<0");
    else if(x ==4)
        Console.WriteLine("x>0 и y<0");
    else
        Console.WriteLine("Такой четверти не существует");
}

int x = InitQuaterByUser(); 
PrintQuarterByCoords(x);
