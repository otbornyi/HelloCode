Console.WriteLine("Введите ваше число : ");
string A = Console.ReadLine();
char[] B = A.ToString().ToCharArray();
int C = 0;

for(int i = 0; i < B.Length; i++)
{
    C++;
}

Console.Write("Цифр в вашем числе : ");
Console.WriteLine(C);

