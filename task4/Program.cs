string converter;
int lenght = 3;
int[] nums = new int[lenght];
Console.WriteLine("Введите a");
converter = Console.ReadLine();
nums[0] = Convert.ToInt32(converter);
int max = nums[0];
Console.WriteLine("Введите b");
converter = Console.ReadLine();
nums[1] = Convert.ToInt32(converter);
Console.WriteLine("Введите c");
converter = Console.ReadLine();
nums[2] = Convert.ToInt32(converter);
for (int i=1;i < lenght; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
}
Console.WriteLine("Max = " + max);
