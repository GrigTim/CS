//По номеру четверти выдает диапазон значений х и y 
#region --- 00. Configuration ---
Console.Clear();
Console.Title = "Задача 19. Является ли введенное 5-ти значное число палиндромом";

Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 19.  Является ли введенное 5-ти значное число палиндромом");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вызов методов, запрашивающих у пользователя целое число. Введённое число присваивается переменной x
int x = GetNumberFromUser();
#endregion --- 01. Input operations ---

#region --- 02. Logic block ---
int polly;
try
{
    // Вызов метода, возвращающего интервал по переданныму номеру четверти.
    // Результат вызова присваивается переменной quarter.
    polly = PollyN(x);
}
catch(Exception exc)
{
    Console.WriteLine($"ОШИБКА! {exc.Message}");
    return; // Завершение программы в случае ошибки
}
#endregion --- 02. Business logic ---

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
static int PollyN(int x)
{
    int a1 = x / 10000;
    int a21 = x / 1000;
    int a2 = a21 - a1 * 10;
    int a5 = x % 10;
    int a4 = (x%100 - a5)/10;
    int exp1 = a1-a2+a4-a5;
    
    if (x <10000)
        Console.WriteLine (" Число не подходит");
    else if (x>99999)
        Console.WriteLine (" Число не подходит");
    if (exp1 == 0)
        Console.WriteLine (" Ага");
    else
        Console.WriteLine ("Неа");
    return x;
}
