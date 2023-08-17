//Задача 36 сумма нечетных элементов массива

#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 36 сумма нечетных элементов массива");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion


Console.Clear();
int lenght = GetNumberFromUser("Введите длинну массива ", "Ошибка ввода");
int[] array = GetArray(lenght, 4, 10);
Console.WriteLine(String.Join(" ", array));
int nchSum = GetChSum(array);
Console.WriteLine($"сумма нечетных элементов = {nchSum}");
// Возвращает массив из size элементов,
// заполненный случайными числами из промежутка [minValue, maxValue]
int[] GetArray(int size, int minValue, int maxValue)
{
     int[] res = new int[size];
     for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
// Возвращает сумму нечетных чисел массива arr
int GetChSum(int[] arr)
{
    int nSum = 0;
    int i = 0;
    foreach (int el in arr)
    {
        i = el % 2; 
         if (i != 0  ) nSum = nSum + el;
    }
    return nSum;
}
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