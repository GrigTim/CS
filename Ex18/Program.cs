//По номеру четверти выдает диапазон значений х и y 
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 18. Определение интервала координат по заданному номеру четверти номера";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 18. Определение интервала координат по заданному номеру четверти номера");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вызов методов, запрашивающих у пользователя целое число. Введённое число присваивается переменной x и y
int x = GetNumberFromUser();
#endregion --- 01. Input operations ---

#region --- 02. Logic block ---
int quarterInt;
try
{
    // Вызов метода, возвращающего интервал по переданныму номеру четверти.
    // Результат вызова присваивается переменной quarter.
    quarterInt = GetQuarterIntByCoords(x);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

#region --- 03. Output operations ---
Console.WriteLine($"Номер четверти: {quarterInt}");
#endregion --- 03. Output operations ---
// -------------------------- Конец программы ----------------------------------


// -------------------------Определение методов ---------------------------------
// Определяем функцию, выполняющую ввод целого числа с консоли
static int GetNumberFromUser()
{   
    while(true)
    {
        try
        {
            Console.Write("Введите целое число: ");
            int num = int.Parse(Console.ReadLine() ?? "");
            return num;
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");        
        }
    }
}
// Определяем функцию, принимающую аргумент и определяющую интервал его четверти
// В случае попадания точки на оси координат генерируется исключение
static int GetQuarterIntByCoords(int x)
{
    if (x == 1)   Console.WriteLine ("x > 0, y > 0");
    else if (x == 2)  Console.WriteLine ("x < 0,  y > 0");
    else if (x == 3)  Console.WriteLine ("x < 0, y < 0");
    else if (x == 4)  Console.WriteLine ("x > 0, y < 0");
    else  Console.WriteLine ("Нет такой четверти!");
    return x;
}
