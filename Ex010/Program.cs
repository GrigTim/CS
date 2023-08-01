// принимает на вход трехзначное число и на выход показывает вторую цифру этого числа
Console.Clear();
Console.WriteLine("Введите трехзначное число ");
int varA;
while (true)
{
    Console.Write ("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine ("Ошибка ввода");
}
Console.WriteLine($" A = {varA}");
int a = varA % 100;
int b = a / 10; 
Console.WriteLine($" {varA} -> {b}");