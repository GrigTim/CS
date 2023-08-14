//Задача 29:Создаем массив из 8 элементов и заполнить его самим с терминала.


#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача 29.  Создаем массив из 8 элементов и заполнить его самим с терминала");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion

#region --- 01. Input operations ---
// Вызов метода, запрашивающего у пользователя координаты 
int [] array = new int [8]; 
  
#endregion --- 01. Input operations ---

#region --- 02. logic and output ---
FillArray (array);
PrintArray (array);  

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
void FillArray (int [] collection)
{
    int lenght = 8;
    int index = 0; 
    while (index<lenght)
    {
        collection [index] = GetNumberFromUser("Введите элемент ", "Ошибка ввода");
        index ++;
    }
}
  
void PrintArray (int [] coll)
{
    int len = 8;
    int ind = 0; 
    while (ind<len)
    {
        Console.Write($"{coll[ind]}; ");
        ind ++;
    }
}
  