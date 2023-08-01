// Определить, является ли введеное второе число кратно введенному первому. Если нет, вывести остаток от деления
Console.WriteLine ("Введите первое число ");
int num1 = int.Parse (Console.ReadLine() ?? "");
Console.WriteLine ("Введите второе число ");
int num2 = int.Parse (Console.ReadLine() ?? "");
int res = num1 % num2;

if (res == 0 )
{
    Console.WriteLine($"{num1} кратно {num2}");
}
else 
{
    Console.WriteLine($"{num1} некратно {num2} остаток -> {res}");
}