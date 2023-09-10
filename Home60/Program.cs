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
#region --- 01. Input operations ---
int x = GetNumberFromUser("Введите размер первого измерения массива ", "Ошибка ввода");

int y = GetNumberFromUser("Введите размер второго измерения массива ", "Ошибка ввода");

int z = GetNumberFromUser("Введите число 3-его измерения массива ", "Ошибка ввода");

#endregion --- 01. Input operations ---

#region --- 02. logic and output ---

Console.WriteLine();
//Проверка актуальности заполнения массива
if(x * y * z <= 99) 
{
    int[,,] array = GetArray3D(x, y, z);
    PrintEl3D(array);
}
else Console.WriteLine("Кажется, интервал значений вне диапазона задачи");

#endregion --- 02. logic and output ---

// -------------------------Определение методов ---------------------------------
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

void PrintEl3D(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.WriteLine($"{inArray[i, j, k]} координаты ({i}, {j}, {k} )");
            }
        }
        Console.Write();
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
