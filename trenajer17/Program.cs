int A = new Random().Next(1, 10);
int B = new Random().Next(1, 100);
Console.WriteLine(A);
Console.WriteLine(B);
if(A * A == B)
{
    Console.WriteLine("Ураааа нашли квадрат!!!");
}
else
{
    Console.WriteLine("Квадрат не найден");
}