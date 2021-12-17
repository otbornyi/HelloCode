long A = 1;
long B = 10;
long C = A;
for(int i = 1; i < B; i++)
{
    C =  C * (A + 1);
    A++;
}
Console.WriteLine(C);