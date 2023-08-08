//Напишите программу, которая принимает на вход N и выдает кубы чисел от до N 

#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 23. Выводим кубы чисел от 1 до N");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя координаты 
int N = GetNumberFromUser("Введите N ", "Ошибка ввода");

#endregion --- 01. Input operations ---

#region --- 02. logic and output ---
double cubeN;
try
{
    // Вызов метода, возвращающего куб числа. а поскольку массивы мы пока не, то и вывод тут же
    int count = 0;
    while (count < N)
    {
        cubeN = CubeNum (count);
        Console.WriteLine($" куб {count} равен {cubeN}");
        count ++;
    }
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. logic and output ---


// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser(string message, string errorMessage)
{   
    while(true)
    {
        try
        {
            Console.Write(message);
            return int.Parse(Console.ReadLine() ?? "");            
        }
        catch (Exception exc)
        {
            Console.WriteLine($"{errorMessage} {exc.Message}");        
        }
    }
}

static double CubeNum(int x)
{
    double c = Math.Pow(x, 3); 
    return c;
}
