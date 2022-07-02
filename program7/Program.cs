Console.Write("Введите день недели (от 1 до 7): ");
int Day = Convert.ToInt32(Console.ReadLine());

int saturday = 6,
    sunday = 7;

if (Day == saturday || Day == sunday)
{
    Console.WriteLine("Выходной день");
}
else if (Day > 7 || Day <= 0)
{
    Console.WriteLine("Необходимо использовать только цифры от 1 до 7");
}
else
{
    Console.WriteLine("Не выходной день");
}
