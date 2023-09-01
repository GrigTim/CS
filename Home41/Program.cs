//Задача 41: Пользователь вводит с клавы M чисел. Определить сколько из них больше 0


#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 41.  Пользователь вводит с клавы M чисел. Определить сколько из них больше 0
");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя координаты 
int lon = GetNumberFromUser("Введите количество элементов ", "Ошибка ввода");
int [] array = new int [lon]; 
  
#endregion --- 01. Input operations ---

#region --- 02. logic and output ---
FillArray (array);
PrintArray (array);  
int chSum = GetChSum(array);
Console.WriteLine($"Chetny sum = {chSum}");
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
int GetChSum(int[] arr)
{
    int positiveSum = 0;
    int i = 0;
    foreach (int el in arr)
    {
        i = el % 2; 
         if (i == 0  ) positiveSum ++;
    }
    return positiveSum;
}
void FillArray (int [] collection)
{
    int lenght = array.Length;
    int index = 0; 
    while (index<lenght)
    {
        collection [index] = GetNumberFromUser("Введите элемент ", "Ошибка ввода");
        index ++;
    }
}
  
void PrintArray (int [] coll)
{
    int len = array.Length;
    int ind = 0; 
    while (ind<len)
    {
        Console.Write($"{coll[ind]}; ");
        ind ++;
    }
}
