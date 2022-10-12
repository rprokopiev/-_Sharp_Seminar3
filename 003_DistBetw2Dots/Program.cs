int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int Xa = PrintAndGetValue("Введите координтау X для точки А");
int Ya = PrintAndGetValue("Введите координтау Y для точки А");
int Xb = PrintAndGetValue("Введите координтау X для точки B");
int Yb = PrintAndGetValue("Введите координтау Y для точки B");

double xPow = Math.Pow((Xa-Xb), 2);
double yPow = Math.Pow((Ya-Yb), 2);
double AB = Math.Sqrt(xPow+yPow);

Console.WriteLine(AB);