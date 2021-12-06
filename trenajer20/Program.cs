int A = 1;
int B = 2;
int C = 3;
int D = 4;
Console.Write("Введите номер плоскости: ");
int num = int.Parse(Console.ReadLine());

if(num > 0 && num < 5)
{
    Console.WriteLine("Возможные координаты в данной плоскости:");
    if (num == A)
    {
        Console.Write("X = ");
        Console.WriteLine("1, 2, 3, 4, 5");
        Console.Write("Y = ");
        Console.WriteLine("1, 2, 3, 4, 5");
    }
    if (num == B)
    {
        Console.Write("X = ");
        Console.WriteLine("-5, -4, -3, -2, -1");
        Console.Write("Y = ");
        Console.WriteLine("1, 2, 3, 4, 5");
    }
    if (num == C)
    {
        Console.Write("X = ");
        Console.WriteLine("-5, -4, -3, -2, -1");
        Console.Write("Y = ");
        Console.WriteLine("-5, -4, -3, -2, -1");
    }
    if (num == D)
    {
        Console.Write("X = ");
        Console.WriteLine("1, 2, 3, 4, 5");
        Console.Write("Y = ");
        Console.WriteLine("-5, -4, -3, -2, -1");
    }
}
else
{
    Console.WriteLine("Введите значение от 1 до 4!!!");
}




//Console.Write("Выбрана плоскость - ");
//Console.WriteLine(Z);