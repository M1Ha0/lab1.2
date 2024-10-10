try
{
    Console.WriteLine("Введите R1");
    double r1 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите R2");
    double r2 = double.Parse(Console.ReadLine());
    Console.WriteLine("Введите R3");
    double r3 = double.Parse(Console.ReadLine());
    double v1 = (4.0 / 3.0 ) * Math.PI * r1 * r1 * r1;
    double v2 = (4.0 / 3.0 ) * Math.PI * r2 * r2 * r2;
    double v3 = (4.0 / 3.0) * Math.PI * r3 * r3 * r3;
    Console.WriteLine($"Z={(v1 + v2 + v3) / 3}");
}
catch
{
    Console.WriteLine("Введите корректные данные");
}