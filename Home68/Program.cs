//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

#region --- 00. Configuration ---

Console.Clear();

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 68 Напишите программу вычисления функции Аккермана с помощью рекурсии");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---

int m = GetNumberFromUser("Введите число  m = ", "Ошибка ввода");

int n = GetNumberFromUser("Введите число n = ", "Ошибка ввода");

#endregion --- 01. Input operations ---

#region --- 02. logic and output ---

int result = GetAkkermanNM(m, n);
Console.Write($" результат {result}");

#endregion --- 02. logic and output ---


// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------

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

int GetAkkermanNM (int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M > 0)
    {
        return GetAkkermanNM(M - 1, 1);
    }
    else
    {
        return (GetAkkermanNM(M - 1, GetAkkermanNM(M, N - 1)));
    }
}
