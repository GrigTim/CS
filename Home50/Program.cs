//Задача 50 поиск элемента по заданным координатам


#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 50. Поиск элемента массива по заданным координатам");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вводим число строк и столбцов
int rows = GetNumberFromUser("Введите число строк двумерного массива ", "Ошибка ввода");
int columns = GetNumberFromUser("Введите число столбцов двумерного массива ", "Ошибка ввода");
int findrow = GetNumberFromUser("Введите строку искомого ", "Ошибка ввода");
int findcolumn = GetNumberFromUser("Введите номер столбца искомого", "Ошибка ввода");
  
#endregion --- 01. Input operations ---

#region --- 02. logic and output ---
// Метод создающий массив (, означает что он двумерный. Трехмерный был бы [ , ,] и тд )
// Тут у нас есть максимальный и минимальный элемент. И тип данных массива инт. 
int[,] array = GetArray (rows, columns, 0, 10);
PrintArray(array);
FindElementArray(array, findrow, findcolumn);


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
void FindElementArray(int[,] fArray, int findr, int findc)
{
    int elementf = 0; 
    for (int i = 0; i < fArray.GetLength(0); i++)
    {
        for (int j = 0; j < fArray.GetLength(1); j++)
        {
            if ( i== findr && j == findc)
            elementf = fArray[i-1, j-1]; 
        }
        Console.WriteLine();
    }
    if (elementf ==  0)
    {
        Console.WriteLine("элемент не найден");
    }
    else 
    {
        Console.Write($"{elementf} = искомый эелемент ");
    }
}
