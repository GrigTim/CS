//Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.


#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вводим число строк и столбцов
int rows = GetNumberFromUser("Введите число строк двумерного массива ", "Ошибка ввода");
int columns = GetNumberFromUser("Введите число столбцов двумерного массива ", "Ошибка ввода");
  
#endregion --- 01. Input operations ---

#region --- 02. logic and output ---
// Метод создающий массив (, означает что он двумерный. Трехмерный был бы [ , ,] и тд )
// 
int[,] array = GetArray (rows, columns, 0, 10);
PrintArray(array);
FindSummC(array);


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
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}
void FindSummC(int[,] fArray)
{
    double summ = 0;
    double summS = 0;
    int n = 0;
    for (int i = 0; i < fArray.GetLength(1); i++)
    {
        for (int j = 0; j < fArray.GetLength(0); j++)
        {
            summ = summ +  fArray [j, i];
        }
        Console.WriteLine();
        summS = summ / fArray.GetLength(0);
        n++;
        Console.Write($"{summS} = среднее арифметическое {n} столбца");
        summ = 0;
    }
}