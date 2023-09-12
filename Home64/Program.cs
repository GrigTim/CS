//Задача 64: Выведет все натуральные числа в промежутке от N до M

#region --- 00. Configuration ---

Console.Clear();

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 64 Выведет все натуральные числа в промежутке от N до M");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---

int m = GetNumberFromUser("Введите число  m = ", "Ошибка ввода");

int n = GetNumberFromUser("Введите число n = ", "Ошибка ввода");

#endregion --- 01. Input operations ---

#region --- 02. logic and output ---

string result = GetNumbersRec(m, n);
Console.Write($" результат  {result}");


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
string GetNumbersRec (int M, int N)
{
    if(N >= M) return $"{N}; " + GetNumbersRec(M, N - 1);
    else return String.Empty;
}
