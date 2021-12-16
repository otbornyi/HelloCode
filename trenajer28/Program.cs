int A = 44444444;
int Q = 0;
while (A > 10)
{
    Q = Q + (A % 10);
    A = A / 10;
}
Q = Q + A;



Console.WriteLine(Q);