//int A = 764;
//int B = A % 10;
//int C = (A - (A % 100)) / 10 + B;
//Console.WriteLine(C);
int A = new Random().Next(100, 1000);
Console.WriteLine(A);
int B = A % 10;
int C = (A - (A % 100)) / 10 + B;
Console.WriteLine(C);