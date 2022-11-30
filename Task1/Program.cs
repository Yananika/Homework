Console.Clear();
Console.WriteLine("Введите первое число:");
int firstnumber = int.Parse (Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondnumber = int.Parse (Console.ReadLine());

int maxnumber = firstnumber;
if (firstnumber>secondnumber)
{
    Console.Write($"Максимальное число {firstnumber}");
}
else Console.Write($"Максимальное число {secondnumber}");