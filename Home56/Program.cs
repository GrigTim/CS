//Задача 56 Напишите программу, которая будет находить строку с наименьшей суммой элементов.

#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 56 Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
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


Console.WriteLine ("   ");
int[] sumRows = GetSumRows(array);
GetIndexMinRow (sumRows);

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

// метод создает массив одномерный, где каждый элемент это сумма соответствующих строк.

int[] GetSumRows(int[,] inArray)
{    
    int[] sumR = new int[inArray.GetLength(0)]; 

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sum =sum + inArray[i,j];
        }
        sumR[i] = sum;
    }
    return sumR;
}

// ну, по идее, можно было бы сразу в один метод все запихать, но говорят, что много циклов вложенных друг в друга, плохо. 
void GetIndexMinRow(int[] inArray)
{
    int min = 0;
    for (int i = 1; i < inArray.Length; i++)
    {
        if(inArray[min] < inArray[i]) 
        min = i;
    }
    Console.Write($"{min}  строка с наименьшей суммой");
}