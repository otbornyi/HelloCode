int X = new Random().Next(-10, 10);
Console.WriteLine(X);
int Y = new Random().Next(-10, 10);
Console.WriteLine(Y);
if(X == 0)
{
    Console.WriteLine("Не выполнены условия задачи!!!");
}
if(Y == 0)
{
    Console.WriteLine("Не выполнены условия задачи!!!");
}

if(X != 0 && Y != 0)
{
    if(X > 0 && Y > 0)
    {
        Console.WriteLine("Это первая четверть");
    }
}
if(X != 0 && Y != 0)
{
    if(X < 0 && Y > 0)
    {
        Console.WriteLine("Это вторая четверть");
    }
}
if(X != 0 && Y != 0)
{
    if(X < 0 && Y < 0)
    {
        Console.WriteLine("Это третья четверть");
    }
}
if(X != 0 && Y != 0)
{
    if(X > 0 && Y < 0)
    {
        Console.WriteLine("Это четвертая четверть");
    }
}