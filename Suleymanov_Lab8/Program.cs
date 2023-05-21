void one()
{
    const double a = -2 * Math.PI;
    const double b = 2 * Math.PI;
    const double dx = Math.PI / 6;

    MyFunc func = MyClass.MethodA;
    Console.WriteLine($"{"x",10} {"f(x)",20}");
    Tabulate(func, a, b, dx);

    MyClass x = new MyClass();
    func = x.MethodB;
    Console.WriteLine($"{"x",10} {"f(x)",20}");
    Tabulate(func, a, b, dx);

    func = x => -Math.Pow((x / Math.PI), 2) - 2 * x + 5 * Math.PI;
    Console.WriteLine($"{"x",10} {"f(x)",20}");
    Tabulate(func, a, b, dx);

    func = delegate (double x)
    {
        double res = 0;
        for (int i = 1; i <= 100; i++)
        {
            res += Math.Pow(((x / (Math.PI * i)) - 1), 2);
        }
        return res;
    };
    Console.WriteLine($"{"x",10} {"f(x)",20}");
    Tabulate(func, a, b, dx);

    func = x =>
    {
        if (x < 0) return (1 / 4.0) * Math.Pow(Math.Sin(x), 2) + 1;
        else return (1 / 2.0) * Math.Cos(x) - 1;
    };
    Console.WriteLine($"{"x",10} {"f(x)",20}");
    Tabulate(func, a, b, dx);

    static void Tabulate(MyFunc f, double a, double b, double dx)
    {
        for (double x = a; x <= b; x += dx)
        {
            Console.WriteLine($"{x} = {f(x)}");
        }
    }
}

void two()
{
    Func<double, double> myFunc = x;
}

class MyClass
{
    public static double MethodA(double x)
    {
        return Math.Cos(x);
    }
    public double MethodB(double x)
    {
        return 2 * Math.Sqrt(Math.Abs(x - 1)) + 1;
    }
}

delegate double MyFunc(double x);