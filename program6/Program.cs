Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.Write("Третьей цифры нет");
}
else
{
    while (number > 999)
    {
        number = number / 10;
    }
    Console.Write("Третья цифра заданного числа равна " + number % 10);

}