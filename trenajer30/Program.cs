double A = new Random().Next(1,50);
Console.Write("При А = ");
Console.WriteLine(A);
double B = new Random().Next(1,50);
Console.Write("При B = ");
Console.WriteLine(B);
double C = new Random().Next(1,50);
Console.Write("При C = ");
Console.WriteLine(C);
if(A % 2 == 0)
{
    A = Math.Pow(A, 3);
    Console.WriteLine(A);
}
if(B % 2 == 0)
{
    B = Math.Pow(B, 3);
    Console.WriteLine(B);
}
if(C % 2 == 0)
{
    C = Math.Pow(C, 3);
    Console.WriteLine(C);
}

