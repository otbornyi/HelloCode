int A = new Random().Next(100, 1000);
int B = A % 100;
double x = floor(B)/10;
Console.WriteLine(A);
Console.WriteLine(B);
Console.WriteLine(x);