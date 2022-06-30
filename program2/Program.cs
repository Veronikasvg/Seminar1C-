Console.Write("Введите число1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число3: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    if (a > c)
    {
        Console.WriteLine("max = " + a);
    }
    else if (a == c)
    {
        Console.WriteLine("max = " + a);
    }
    else
    {
        Console.WriteLine("max = " + c);
    }
}
else if (a == b)
{
    if (a > c)
    {
        Console.WriteLine("max = " + a);
    }
    else
    {
        Console.WriteLine("max = " + c);
    }
}
else
{
    if (a > c)
    {
        Console.WriteLine("max = " + b);
    }
    else if (b == c)
    {
        Console.WriteLine("max = " + b);
    }
    else
    {
        Console.WriteLine("max = " + c);
    }

}