string converter;
int N;
Console.WriteLine("Введите число");
converter = Console.ReadLine();
N = Convert.ToInt32(converter);
while (N>0)
{
    if (N % 2 == 0)
    {
        Console.Write(N +",");
    }
    N--;
}
