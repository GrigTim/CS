//Напишите программу, которая принимает на вход координаты двух точек в 3-х метрном пространстве, 
//и определяет между ними расстояние.
// -------------------------- Начало программы ----------------------------------
#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 21.  Опеределить по введенным коорд двух точек расстояние между ними");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя координаты 
int x1 = GetNumberFromUser("Введите координату по оси x ", "Ошибка ввода");
int y1 = GetNumberFromUser("Введите координату по оси y ", "Ошибка ввода");
int z1 = GetNumberFromUser("Введите координату по оси z ", "Ошибка ввода");

int x2 = GetNumberFromUser("Введите координату по оси x ", "Ошибка ввода");
int y2 = GetNumberFromUser("Введите координату по оси y ", "Ошибка ввода");
int z2 = GetNumberFromUser("Введите координату по оси z ", "Ошибка ввода");
#endregion --- 01. Input operations ---

#region --- 02. Business logic ---
double l;
try
{
    // Вызов метода, возвращающего длину отрезка.
    
    l = LongLine(x1, y1, z1, x2, y2, z2);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"Удав слишком длинный стал: {l}");
#endregion --- 03. Output operations ---
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

static double LongLine(int xa, int ya, int za, int xb, int yb, int zb)
{
    double lline = Math.Pow(Math.Pow((xb-xa), 2) + Math.Pow((yb-ya), 2) + Math.Pow ((zb - za), 2), 0.5); 
    return lline;
   
}
// ---------------------- Конец определения методов ----------------------------