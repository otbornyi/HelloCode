int a = 46;
string str = a.ToString();
int[] b = new int[str.Length];
for( int i=0; i<str.Length; i++)
{
    b[i] = int.Parse(str[i].ToString());
}
int n = b[0];
if(b[1] > b[0])
{
    Console.WriteLine(b[1]);
}
else
{
    Console.WriteLine(b[0]);
}
