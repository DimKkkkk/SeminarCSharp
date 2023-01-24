/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/
Console.Clear();

double[] array = new double[4];
GetNumbersFromUser(array);
double cordX = GetCordinateX(array[0]);
double cordY = GetCordinateY(array[1]);

Console.Write($"b1 = {array[0]}, k1 = {array[1]}, b2 = {array[2]}, k2 = {array[3]} -> ");

if(array[1] == array[3]) Console.WriteLine("Прямые параллельны и не пересекаются!"); 
else Console.WriteLine($"Прямые пересекаются в точке ({cordX}; {cordY})");

void GetNumbersFromUser (double[] numbers)
{
	double lengthArray = numbers.Length;
	for(int i = 0; i < lengthArray; i++)
	{        
		Console.WriteLine($"Введите значение координаты: ");
	    bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if(isCorrect)
		{
		numbers[i] = num;
		}
	    else Console.WriteLine("Ошибка ввода!");
    }
}




double GetCordinateX(double X)
{
	X = (array[2]-array[0])/(array[1]-array[3]);
	return X;
}

double GetCordinateY(double Y)
{
	Y = array[3] * cordX + array[2];
	return Y;
}
