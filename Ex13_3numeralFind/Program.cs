// Найти третью цифру числа или сообщить, что ее нет. 
Console.Clear();
int varA;
while (true)
{
    Console.Write ("Введите число: ");
    if (int.TryParse(Console.ReadLine(), out varA))
        break;
    Console.WriteLine ("Ошибка ввода");
}
// если отрицательное
int num = varA;
if (varA < 0 )  
{
    num = varA* (-1);
}
if (num < 100)
{
    Console.WriteLine("нет третьей цифры");
}
else 
{
    int a123 = num % 1000;
    int a12 = num % 100;
    int a3 = (a123 - a12)/100;
    Console.WriteLine($" {varA} - > {a3}");
}