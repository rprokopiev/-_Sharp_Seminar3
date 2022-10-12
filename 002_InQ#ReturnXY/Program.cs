int PrintAndGetValue(string message)
{
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    return value;
}

int input = PrintAndGetValue("Введите № четверти");

switch(input)
{
    case 1:
        Console.WriteLine("X > 0; Y > 0");
        break;
    case 2:
        Console.WriteLine("X < 0; Y > 0");
        break;
    case 3:
        Console.WriteLine("X < 0; Y < 0");
        break;
    case 4:
        Console.WriteLine("X > 0; Y < 0");
        break;
    default:
        Console.WriteLine("Ошибка ввода");
        break;
}
