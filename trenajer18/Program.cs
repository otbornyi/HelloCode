int A = 12;
int B = 25;
int C = 100 - (12 + 25);
Console.WriteLine(C);
int D = ((100 - 25 - 12));
Console.WriteLine(D);
if(C == D)
{
    Console.WriteLine("Утверждение ¬(12 ⋁ 25) = ¬12 ⋀ ¬25 - ВЕРНОЕ! ");
}
else
{
    Console.WriteLine("Утверждение ¬(12 ⋁ 25) = ¬12 ⋀ ¬25 - НЕВЕРНОЕ! ");
}