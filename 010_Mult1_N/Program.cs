Console.WriteLine("Введите число");
int Num = int.Parse(Console.ReadLine());
int m = 1;
int i = 1;
while (i <= Num)
{
    m = m*i;
    i++;
}
Console.WriteLine(m);