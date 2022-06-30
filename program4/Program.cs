Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
int min = 1;

if (n < 1)
{
    Console.WriteLine("Введите число больше 1");
}
else if (n == 1)
{
    Console.WriteLine("Нет четных чисел");
}
else
{
    while (min <= n)
    {
        if (min % 2 == 0)
        {
            if ((n - min) == 1)
            {
                Console.Write(min);
                min += 2;
            }
            else if ((n - min) == 0)
            {
                Console.Write(min);
                min += 2;
            }
            else
            {
                Console.Write(min + ", ");
                min += 2;
            }
        }
        else
        {
            min++;

        }
    }
}