string converter;
int a;
int b;
Console.WriteLine("Введите a");
converter = Console.ReadLine();
a = Convert.ToInt32(converter);
Console.WriteLine("Введите b");
converter = Console.ReadLine();
b = Convert.ToInt32(converter);
if (a>b)
{
Console.WriteLine("Максимальное число - " + a);
}
else
Console.WriteLine("Максимальное число - " + b);
