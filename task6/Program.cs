string converter;
int num;
Console.WriteLine("Введите число");
converter = Console.ReadLine();
num = Convert.ToInt32(converter);
if (num % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
