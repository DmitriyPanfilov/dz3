// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


public class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int remineder, sum = 0;
        int temp = number;
        while (number > 0)
        {
            remineder = number % 10; //разделяем число по 1 цифре
          
            sum = (sum * 10) + remineder; //переворачиваем число прибавляя к последней цфре
        
            number = number / 10; //проверяем количество оставшихся цифр в числе
           
        }
        if (temp == sum)
        {
            Console.WriteLine($"Number {temp} is Palindrome.");
        }
        else
        {
            Console.WriteLine($"Number {temp} is not Palindrome");
        }
        Console.ReadKey();
    }
}

