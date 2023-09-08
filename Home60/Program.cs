//Задача 60 3д массив из неповтор 2-хзначных чисел, вывести с координатами

#region --- 00. Configuration ---
Console.Clear();


Console.OutputEncoding = System.Text.Encoding.UTF8;
var curConsoleColor = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine(@"Задача  60 3д массив из неповтор 2-хзначных чисел, вывести с координатами");
Console.ForegroundColor = curConsoleColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
#endregion
//Тут мне помогали, так что привычной разметки нема.  

int x = GetNumberFromUser("Введите размер первого измерения массива ", "Ошибка ввода");

int y = GetNumberFromUser("Введите размер второго измерения массива ", "Ошибка ввода");

int z = GetNumberFromUser("Введите число 3-его измерения массива ", "Ошибка ввода");

Console.WriteLine();

if(x * y * z <= 99) 
{
    int[,,] array = GetArray3D(x, y, z);
    PrintElementArray3D(array);
}
else Console.WriteLine("Тут что то не так.");



// Эту задачу я решал с помощью, так что привычной разметки хрен. Ну, может, потом переделаю 
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

void PrintElementArray3D(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.WriteLine($"{inArray[i, j, k]}({i}, {j}, {k} )");
            }
        }
        Console.WriteLine();
    }
}

int[,,] GetArray3D(int X, int Y, int Z)
{
    int min = 10;
    int[,,] result = new int[X, Y, Z];
    for (int i = 0; i < X; i++)
    {
        for (int j = 0; j < Y; j++)
        {
            for (int k = 0; k < Z; k++)
            {
                result[i, j, k] = min;
                min++;
            }
        }
    }
    return result;
}
