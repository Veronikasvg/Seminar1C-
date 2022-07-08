// принимает на вход число и выдает таблицу кубов
Console.Write($"Введите число от 1 до {int.MaxValue}: ");
int userNumber = Convert.ToInt32(Console.ReadLine()),
count = 1;
string result = "";

while (count <= userNumber)
{
    result += count * count * count;
    if (count != userNumber)
    {
    result += ", "; 
    }
    count++;
}

Console.WriteLine(result);