int A = new Random().Next(1,30);
int B = new Random().Next(1,30);
int C = new Random().Next(1,30);

Console.WriteLine($"A = {A}, B = {B}, C = {C}");

if(A < B + C && B < A + C && C < A + B)
{
    Console.WriteLine("Да, все окей");
}
else
{
    Console.WriteLine("Данные числа не являются сторонами треугольника");
}