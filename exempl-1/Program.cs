// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");

string? numberString = Console.ReadLine();

int number = int.Parse(numberString!);

if(number < 100 || number > 999)
{
    Console.WriteLine("Число должнобыть => 100 или < 999");
}

else
{
    int firstDigital = number/ 10;

    int secondDigital = number/ 100;

    int result = firstDigital - secondDigital*10;

    Console.WriteLine("Второе число " + result);
}





