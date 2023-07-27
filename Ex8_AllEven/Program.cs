// все четные от 1 до N
Console.WriteLine ("Введите натуральное число");
int number = int.Parse (Console.ReadLine() ?? "");
int i = 2;
while (i < number)
{
    Console.Write($" {i}");
    i=i+2;
}
