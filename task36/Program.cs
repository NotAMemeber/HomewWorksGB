Console.Write("Введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());
int[] randomArray = new int[a];

void mas(int a)
{
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(-1000,1000);
Console.Write(randomArray[i] + " ");
}

}

int summary(int[] randomArray)
{
int summary = 0;
for (int i = 0; i < randomArray.Length; i++)
{
if (i % 2 != 0)
summary = summary + randomArray[i];
}
return summary;
}

mas(a);
Console.Write($"\n Сумма элементов, стоящих на нечетных позициях: {summary(randomArray)}");