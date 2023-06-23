Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number < 1000)   
{
int nam = (number % 10 - number % 1) / 1; 
Console.WriteLine($"Третья цифра числа {number} является {nam}"); 
}
else
Console.WriteLine("Это число не трехзначное");
