string converter;
Console.WriteLine("Введите число");
converter = Console.ReadLine();
int day = Convert.ToInt32(converter);
if ( day > 0 && day < 6)
{
    Console.WriteLine("Нет");
}
else  if (day < 8 && day >0)
{
    Console.WriteLine("Да");
}
else
Console.WriteLine("Не день недели");
