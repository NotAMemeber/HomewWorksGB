Console.WriteLine("Введите число");
double power ()
{
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());
    return Math.Pow(number1,number2);
}
Console.WriteLine(power());