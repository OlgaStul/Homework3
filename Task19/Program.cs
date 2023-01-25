/*  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да   */

int GetNumber(string message)
{
int resultNumber = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out resultNumber) && 9999 < resultNumber && resultNumber < 100000)
{
break;
}
else
{
Console.WriteLine("Ввели не корректное число. Повторите ввод!\n");
}
}
return resultNumber;
}

int number = GetNumber("Введите пятизначное число");
int firstDiditNumber = number / 10000;
int secondDiditNumber = number / 1000;
int secondDiditNumber2 = secondDiditNumber % 10;
int fourthDiditNumber = number / 10;
int fourthDiditNumber2 = fourthDiditNumber % 10;
int fifthDiditNumber2 = number % 10;

if (firstDiditNumber == fifthDiditNumber2 && secondDiditNumber2 == fourthDiditNumber2)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}