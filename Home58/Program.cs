//Задача 58 произведение двух матриц

#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 58 произведение двух матриц");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вводим число строк и столбцов
int rows = GetNumberFromUser("Введите число строк двумерного массива #1 ", "Ошибка ввода");
int columns = GetNumberFromUser("Введите число столбцов двумерного массива #1 ", "Ошибка ввода");
int rows1 = GetNumberFromUser("Введите число строк двумерного массива #2 ", "Ошибка ввода");
int columns1 = GetNumberFromUser("Введите число столбцов двумерного массива #2 ", "Ошибка ввода");
  
#endregion --- 01. Input operations ---

#region --- 02. logic and output ---

int[,] array = GetArray (rows, columns, 0, 10);
PrintArray(array);

Console.WriteLine ("   ");
int[,] array2 = GetArray (rows1, columns1, 0, 10);
PrintArray(array2);

Console.WriteLine ("   ");

int [,] matrix = GetMatrix (array, array2);
PrintArray(matrix);


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
// метод создания массива m*n  с макс и мин значениями, возвращает массив 
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
// метод печати 2-х мерного массива, который подали на вход
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

// метод создает нашу результирующую матрицу. Ну и сначала проверяет на возможность перемножения исходные матрицы

int[,] GetMatrix(int[,] inArray, int [,] inArray2)
{
    if (inArray.GetLength(0) != inArray2.GetLength(1))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }

    int m = inArray.GetLength(1);
    int n = inArray2.GetLength(0);
    int[,] narray = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) 
        {
            narray[i,j] = 0;
           
            for (int k = 0; k < inArray.GetLength(0) ; k++)
            {
            narray[i, j] += inArray[i, k] * inArray2[k, j];
            }
        }
    }
    return narray;
}