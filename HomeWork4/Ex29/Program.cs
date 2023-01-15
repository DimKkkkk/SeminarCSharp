/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/

PrintArr(); 

void PrintArr ()

{
    Console.Write("["); 
    for (int i = 0; i < 8; i++) 
    {
        int num = new Random().Next(0, 100);
        Console.Write($"{num}");
        if (i < 7) Console.Write(", ");
    }
    Console.Write("]");
}