string converter;
Console.WriteLine("Введите число");
converter = Console.ReadLine();
int fullnum = Convert.ToInt32(converter);
Console.WriteLine(fullnum / 100);
if ((fullnum / 100) >= 1)
{
char num = converter[2];
Console.WriteLine("Третья цифра - " + num);
}
else 
Console.WriteLine("третьей цифры нет");