// программа принимает на вход три целых числа и выдает максимальное
Console.Write("Введите первое число ");
int numberA = int.Parse (Console.ReadLine () ?? "");
Console.Write("Введите второе число ");
int numberB = int.Parse (Console.ReadLine () ?? "");

if (numberA == numberB)
{
    Console.WriteLine (" no max ");
}
if (numberA > numberB)
{
    Console.WriteLine ($" max = {numberA}");
}
else
{
    Console.WriteLine ($" max = {numberB}");
}
