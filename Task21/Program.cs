// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Укажите координату точки A(x): ");
double ax = Convert.ToDouble(Console.ReadLine());
Console.Write("Укажите координату точки A(y): ");
double ay = Convert.ToDouble(Console.ReadLine());
Console.Write("Укажите координату точки A(z): ");
double az = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.Write("Укажите координату точки B(x): ");
double bx = Convert.ToDouble(Console.ReadLine());
Console.Write("Укажите координату точки B(y): ");
double by = Convert.ToDouble(Console.ReadLine());
Console.Write("Укажите координату точки B(z): ");
double bz = Convert.ToDouble(Console.ReadLine());

double DistBetweenPoints3d(double ax1, double ay1, double az1, double bx1, double by1, double bz1)
{
    double distBetweenPoints3d = Math.Sqrt(Math.Pow(bx1 - ax1, 2) + Math.Pow(by1 - ay1, 2) + Math.Pow(bz1 - az1, 2));
    return (distBetweenPoints3d);
}

double result = Math.Round(DistBetweenPoints3d(ax, ay, az, bx, by, bz), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками А и В -> {result}");