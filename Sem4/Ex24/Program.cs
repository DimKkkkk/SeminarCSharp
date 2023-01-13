/* Задача 24: Напишите программу, которая принимает на вход число (А) 
и выдаёт сумму чисел от 1 до А	
4 -> 10 (1+2+3+4=10)	
7 -> 28		
8 -> 36
*/

Console.Clear();
int num = GetNumberFromUser("Введите целое число А: ", "Ошибка ввода!"); // заводим метод GetNumberFromUser
int sumNumbers = GetSumNumbers(num); // заводим метод GetSumNumbers
Console.WriteLine($"{num} -> {sumNumbers}");

//Выводит в консоль сообщение message,
// преобразовывает введённую пользователем строку в число типа int.
//В случае ошибки выводит в консоль сообщение errorMessage

int GetNumberFromUser(string message, string errorMessage) // заносим два аргумента string message которое будет нам выводить Введите целое число А:, и  string errorMessage которое будет выводить сообщение об ошибке ввода.
{
    while(true)
    {
        Console.WriteLine(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber); // out int userNumber - создаём внутри TryParse переменную юзернамбер
        if(isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}
// Возвращает сумму чисел от 1 до number
int GetSumNumbers(int number)
{
    int sum = 0; // создаём переменную sum
    while(number > 0) 
    {
        sum += number;  // алгоритм накопления суммы
        number--;
    }
    return sum; // возвращаем наш результат
}