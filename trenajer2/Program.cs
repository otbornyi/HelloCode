int A = new Random().Next(1, 10);
Console.Write("Число (A) ");
Console.Write(A);
int B = 2;
if(Math.Pow(B, 2) == A)
{
Console.Write(" является квадратом числа В");
}
else
{
Console.WriteLine(" не является квадратом числа В");
}

// Проверить является ли число квадратом другого числа.