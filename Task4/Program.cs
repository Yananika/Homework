Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int count = 2;
while(count <= N)
{
    Console.Write($"{count}, ");
    count = count + 2;
}
