int A = new Random().Next(1, 1000);
Console.Write("A = ");
Console.WriteLine(A);
int B = new Random().Next(1, 1000);
Console.Write("B = ");
Console.WriteLine(B);
int C = new Random().Next(1, 1000);
Console.Write("C = ");
Console.WriteLine(C);
int max = A;
if (B > max) max = B;

if (C > max) max = C;
Console.Write("max = ");
Console.WriteLine(max);