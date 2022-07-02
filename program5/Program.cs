Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int number2 = number % 100 / 10;

Console.WriteLine("Вторая цифра заданного числа равна " + number2);


