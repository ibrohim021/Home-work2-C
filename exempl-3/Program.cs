// Задача 15: Напишите программу,
// которая принимает на вход цифру, обозначающую день недели, и 
//проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");

string? numberString = Console.ReadLine();

int numberDay = int.Parse(numberString!);

if (numberDay== 6 || numberDay == 7)
{
    Console.WriteLine("Это выходной Ура!");
}

else if (numberDay < 1 || numberDay >7)
{
    Console.WriteLine("Введите число от 1 до 7");
}

else
{
    Console.WriteLine("Этот день не выходной");
}