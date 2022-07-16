// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем
double k1 = InputInt("k1 = ");
double b1 = InputInt("b1 = ");
double k2 = InputInt("k2 = ");
double b2 = InputInt("b2 = ");

if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны");
    return;
}

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Точка пересечения равна [{x}, {y}]");

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double InputInt(string output)
{
    Console.Write(output);
    return Convert.ToDouble(Console.ReadLine());
}


