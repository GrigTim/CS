Console.WriteLine ("input number");
int num = int.Parse (Console.ReadLine() ?? "");

int a = num % 7;
int b = num % 23;
if (a+b ==0 )
{
    Console.WriteLine ("кратно ");
}
else 
{
    Console.WriteLine ("no");
}
