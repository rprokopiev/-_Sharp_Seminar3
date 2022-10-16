Console.WriteLine("Enter number");
int N =int.Parse(Console.ReadLine());

int m = 0;

while (N=>0)
{    
    N = N / 10;
    m++;
}
Console.WriteLine(m);