// программа принимает на вход два целых числа и выдает, какое больше
Console.Write("Введите первое число ");
int numberA = int.Parse (Console.ReadLine () ?? "");
Console.Write("Введите второе число ");
int numberB = int.Parse (Console.ReadLine () ?? "");

if (numberA > numberB)
{
    Console.WriteLine ($" max = {numberA}");
}
else
{
    Console.WriteLine ($" max = {numberB}");
}
// введение условия с elseif (для варианта когда вводимые числа равны) создает почему то ошибку. В приложении картинка