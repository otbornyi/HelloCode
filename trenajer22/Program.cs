// int xa = 1, ya = 2,
//     xb = 7, yb = 2;

// int xc = xb - xa;
// int xd = yb - ya;

// double M = Math.Sqrt(Math.Pow(xc, 2) + Math.Pow(xd, 2));
// Console.WriteLine(M);



int xa = 1, ya = 2, za = 3,
    xb = 7, yb = 2, zb = 4;
    

int xc = xb - xa;
int xd = yb - ya;
int ze = zb - za;

double R = Math.Sqrt(Math.Pow(xc, 2) + Math.Pow(xd, 2) + Math.Pow(ze, 2));
Console.WriteLine(R);


