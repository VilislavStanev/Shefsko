
static int Lmao(int a, int b)
    {
    return a + b;
    }
static double Smeshen(double a, double b)
{
    return a * b;
}
static void Main()
{
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    Console.WriteLine(Lmao(c, d));
    Console.WriteLine(Smeshen(c, d));
}