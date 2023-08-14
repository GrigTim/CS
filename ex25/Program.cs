//Задача 25:Принимает на вход два числа (A и B) и возводит число A в натуральную степень B.


#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 25.  Принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя координаты 
int a = GetNumberFromUser("Введите A ", "Ошибка ввода");
int b = GetNumberFromUser("Введите B ", "Ошибка ввода");

#endregion --- 01. Input operations ---

#region --- 02. logic and output ---
double degree;

degree = DegreeA(a,b);
Console.WriteLine($" degree {degree}");
      

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

static double DegreeA(double a, double b)
{
    //как запихать условие натуральности в метод GetNumberFronUser я как то не знаю
    //Да и в условии не говорится, что b именно натуральное. 
    if (b < 0) b = b*(-1);
    double c = Math.Pow(a, b); 
    return c;
}
