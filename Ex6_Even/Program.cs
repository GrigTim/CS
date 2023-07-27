Console.WriteLine ("Введите целое число");
int number = int.Parse (Console.ReadLine() ?? "");

if ((number % 2) == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
