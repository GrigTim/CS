//Задача 43: Точка пересечения двух прямых


#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 43. Точка пересечения двух прямых
");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вводим коэффициенты наклона и смещения для уравнения обоих прямых 
int a = GetNumberFromUser("Введите коэф первой прямой ", "Ошибка ввода");
int b = GetNumberFromUser("Введите смещение первой прямой ", "Ошибка ввода");
int c = GetNumberFromUser("Введите коэф второй прямой ", "Ошибка ввода");
int d = GetNumberFromUser("Введите смещение второй прямой ", "Ошибка ввода");
  
#endregion --- 01. Input operations ---

#region --- 02. logic and output ---
// Поскольку лень выдумывать общий метод для обеих координат, то будет два отдельных
double x0 = FindX(a, b, c, d);
double y0 = FindY(a, b, x0);
Console.WriteLine($"координаты = {x0} ; {y0}");
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
static double FindX( int a, int b, int c, int d)
{
    double i =  (c - a) / (b - d);
    return i;
}
static double FindY (int a, int b, double x)
{
    double n =  a * x + b;
    return n; 
}