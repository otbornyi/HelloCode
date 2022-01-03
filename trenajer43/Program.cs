int A = 15487;
int C = 0;
int B = A;
while(B > 1)
{
    B = B / 2;
    C = C + 1;
}
C = C + 1;


// void PrintArray(int[] Z)
// {
//     for (int i = 0; i < Z.Length; i++)
//     {
//         Console.Write($"{Z[i]} ");
//     }
//     Console.WriteLine();
// }

void FillArray(int[] Z)
{
    for (int i = 0; i < Z.Length; i++)
    {
        if(A % 2 == 0)
        {
            Z[i] = 0;
        }
        else
        {
            Z[i] = 1;
        }
        A = A / 2;
    }
}
void returnArray(int[] Z)
{
    for (int i = 0; i < Z.Length; i++)
    {
        Console.Write($"{Z[C - 1]} ");
        C = C - 1;
    }

}

int[] Z = new int[C];
FillArray(Z);
// PrintArray(Z);
returnArray(Z);

// Программа вычисления из десятичной системы в двоичную.
