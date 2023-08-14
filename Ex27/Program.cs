//Задача 27: Сумма цифр числа.


#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 27.  Сумма цифр введенного числа");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя целое число 
int a = GetNumberFromUser("Введите число ", "Ошибка ввода");

#endregion --- 01. Input operations ---

#region --- 02. logic and output ---
int summ;

summ = SummA(a);
Console.WriteLine($" сумма цифр в числе {summ}");
      

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

static int SummA(int a)
{
    int s = 0;
    while (a > 0)
    { 
        s = s + a % 10;
        a = a /10 ;
    }
    return s;
}