//Задача 38 наибольшая разница между значениями массива

#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 38 наибольшая разница между значениями массива");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion


Console.Clear();
int lenght = GetNumberFromUser("Введите длинну массива ", "Ошибка ввода");
int[] array = GetArray(lenght, 4, 10);
Console.WriteLine(String.Join(" ", array));
int diffAr = GetDiff(array);
Console.WriteLine($"интервал значений = {diffAr}");
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
// Возвращает разницу
int GetDiff(int[] arr)
{
    int max = 0;
    int min = arr [0]; 
    foreach (int el in arr)
    {
        if (max < el ) max = el;
        if (el < min ) min = el; 
    }
    int dif = max - min; 
    return dif;
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