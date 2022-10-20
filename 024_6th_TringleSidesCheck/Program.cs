void IsTrianglePossible (string message1, string message2, string message3)
{
    Console.WriteLine(message1);
    int A = int.Parse(Console.ReadLine());
    Console.WriteLine(message2);
    int B = int.Parse(Console.ReadLine());
    Console.WriteLine(message3);
    int C = int.Parse(Console.ReadLine());
    if (A < B + C && B < A + C && C < A + B)
    {
        Console.WriteLine("Треугольник со сторонами " + A + ", " + B + " и " + C + " возможен.");
    }
    else
    {
        Console.WriteLine("Не может быть построен треугольник со сторонами " + A + ", " + B + " и " + C +".");
    }       
}

IsTrianglePossible("Введите длинну 1й стороны", "2й", "и 3й");
