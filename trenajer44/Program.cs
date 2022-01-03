int b1 = 5;
int b2 = 9;
int k1 = 5;
int k2 = 1;

if(k1 == k2)
{
    Console.WriteLine("Эти лини параллельны, и не имеют точку пересечения");
}


double x = (double)(b2 - b1)/(k1 - k2);
Console.WriteLine(x);
double y1 = k1 * x + b1;
Console.WriteLine(y1);
double y2 = k2 * x + b2;
Console.WriteLine(y2);

if(y1 == y2)
{
    Console.WriteLine("Точка пересечения найдена");
}