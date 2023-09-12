// Задача 66: Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

#region --- 00. Configuration ---
 
 Console.Clear();
Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 66 Сумма натуральных элементов в промежутке от M до N.");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---

int m = GetNumberFromUser("Введите число  m = ", "Ошибка ввода");

int n = GetNumberFromUser("Введите число n = ", "Ошибка ввода");

#endregion --- 01. Input operations ---

#region --- 02. logic and output ---

int result = GetSumNM(m, n);
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

int GetSumNM (int M, int N)
{
    int sum = 0;
    if(M <= N) sum += M + GetSumNM(M+1,N);
    return sum;
}
