// Палиндром
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine()),
firstnumber = number / 10000,
secondnumber = number % 10000 / 1000,
thirdnumber = number % 100 / 10,
lastnumber = number % 10;
if (number >= 10000 && number < 100000)
{
    if (firstnumber == lastnumber && secondnumber == thirdnumber)
    {
        Console.WriteLine("Палиндром");
    }
    else
    {
        Console.WriteLine("Не палиндром");
    }
}
else
{
    Console.WriteLine("Неверное число");
}