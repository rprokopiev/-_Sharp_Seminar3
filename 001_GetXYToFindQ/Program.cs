// ЗАМЕНЯЕМ ПОВТОРЯЮЩИЕСЯ СТРОЧКИ НИЖЕ СОЗДАННЫМ МЕТОДОМ

// Console.WriteLine("Введите X");
// int X = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите Y");
// int Y = int.Parse(Console.ReadLine());

int X = PrintAndGetValue("Введите X");
int Y = PrintAndGetValue("Введите Y");

if (X>0 && Y>0)
{
    Console.WriteLine("1");
}
else if(X<0 && Y>0)
{
    Console.WriteLine("2");
}
else if(X>0 && Y<0)
{
    Console.WriteLine("4");
}
else if(X<0 && Y<0)
{
    Console.WriteLine("3");
}
else
{
    Console.WriteLine("Error");
}

// МЕТОД ДЛЯ ЗАПРОСА ДАННЫХ, ИХ СЧИТЫВАНИЯ И ПРЕОБРАЗОВАНИЯ В int.
int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}