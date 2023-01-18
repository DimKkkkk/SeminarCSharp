/* Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

/* int N = CheckingTheArrayLengthEnteredByTheUser();
double[] array = ArrayFormation(N);
PrintArray(array)

int CheckingTheArrayLengthEnteredByTheUser()

double CheckingTheArrayLengthEnteredByTheUser()

double[] ArrayFormation(int N)
{
    double[] userArray = new double[N];
    int i = 0;
    while (N > 0)
    {
        userArray[i] = CheckingTheArrayLengthEnteredByTheUser();
        i++;
        N--;
    }
    return userArray;
}
*/

int[] array = GetRandomArray(8, 0, 100); // присваиваем метод и его название, в скобках задаём параметры что будем передавать в этот метод: размер, мин и макс диапазон чисел в массиве.
Console.WriteLine($"[{String.Join(", ", array)}]"); // выводим массив в консоль. String.Join клас стринг имеет метод Join который берёт результаты и объединяет их. Устанавливаем разделители в виде запятой и скобки квадратные. ", ", - это первый параметр, array второй параметр.

int[] GetRandomArray(int size, int min, int max) // определяем этот метод. в скобках определяем три параметра ранее заявленных в методе.
{
    int [] result = new int [size]; // создаём переменную с размером массива
    var rnd = new Random(); //вынесли объект генератора new Random за цикл и присваиваем rnd объект класса Random
    for (int i=0; i <size; i++) // делаем цикл, в который мы будет складывать числа в наш массив
    {
        result[i] = rnd.Next(min, max); // i-тому резалт присваиваем некоторое сгенерированное случ число
    }
    return result;
}