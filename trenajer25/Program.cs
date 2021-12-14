int A = 1;
int B = new Random().Next(1, 1000);
int Z = A;

for(int i = 1; i < B; i++)
{
    Z = Z + (A + 1);
    A++;
}
Console.WriteLine();
Console.Write("Факториалом числа ");
Console.Write(B);
Console.Write(" является - ");
Console.WriteLine(Z);
Console.WriteLine();
