class Program
{
    //Этот метод должен возвращать случайное значение
    static int GetRandom()
    {
        //Создание объекта для генерации чисел (с указанием начального значения)
        Random rnd = new Random();
 
        //Получить случайное число 
        int value = rnd.Next(0, 100);
 
        //Вернуть полученное значение
        return value;
    }
 
    static void Main(string[] args)
    {        
        //Вывод сгенерированных чисел в консоль
        Console.Write("[");
        Console.Write(GetRandom());
        Console.Write(GetRandom());
        Console.Write(GetRandom());
        Console.Write("]");
    }
}