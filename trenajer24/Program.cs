int A = 1;
Console.Write("Enter number: ");

int num = int.Parse(Console.ReadLine());

double cube()
{
    double C = Math.Pow(A, 3);
    return C;
}

for(int i = 1; i < num; i++)
{
    Console.Write(A);
    Console.Write(" в кубе = ");
    Console.WriteLine(cube());
    A++;
}
