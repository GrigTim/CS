//Задача 55 замена строк на столбцы в двухмерном массиве

#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 53: Задайте двумерный массив. Напишите программу,которая поменяет местами строки и столбцы");
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
// Тут у нас есть максимальный и минимальный элемент. И тип данных массива инт. 
int[,] array = GetArray (rows, columns, 0, 10);
PrintArray(array);

int [,] arrayRes = GetReplaceRowCol (array);
Console.WriteLine ("   ");
PrintArray(arrayRes);



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

// вот этот метод меняет строки местами 
int [,] GetReplaceRowCol (int[,] inarray)
{
    int [] l  = GetCount(inarray);
    //строка создает новый массив, размерностью наоборот от исходного
    int [,] result = new int [l[1], l[0]];
    for (int j = 0; j < inarray.GetLength(1); j++)
    {
        for (int row = 0; row< result.GetLength(1); row++)
        {
            result [j,row] = inarray [row, j];
        }
    }
    return result;
}
// создает простой массив из двух элементов, который хранит число строк и столбцов исходного массива
 int [] GetCount (int [,] inArray)
{
    int[] res = new int [2];
    res [0] = inArray.GetLength(0);
    res [1]= inArray.GetLength(1);
    return res;
}