// На входную цифру отвечает, выходной день недели или нет. 
Console.Clear();
int day;
while (true)
{
    Console.Write ("Введите номер дня: ");
    if (int.TryParse(Console.ReadLine(), out day))
        break;
    Console.WriteLine ("Ошибка ввода");
}
if (day >7 || day <1)
{
    Console.WriteLine("Нет такого дня ");
}
if (day == 6) Console.WriteLine($" сегодня  выходной {day} - > Суббота ");
if (day == 7) Console.WriteLine($" сегодня выходной {day} - > Воскресенье ");
if (day < 6) Console.WriteLine($" сегодня {day} - рабочий день ");
