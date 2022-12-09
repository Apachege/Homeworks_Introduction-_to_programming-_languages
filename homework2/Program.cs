// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

// int Num2(int num){
//     int num2 = num/10%10;
//     Console.WriteLine($"Вторая цифра числа - {num2}");
//     return num2;       
// }

// Console.WriteLine("Введите трехзначное число");
// int user = Convert.ToInt32(Console.ReadLine());

// if (user < 100 || user >= 1000)
//     Console.WriteLine("Введенное число не трехзначное");
    
// else {
//     Num2(user);
//     Console.WriteLine();}




// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter number: ");
int numb = Convert.ToInt32(Console.ReadLine());

if(numb>0 || numb<6)
{
Console.WriteLine("нет");
}
else if(numb>5 || numb<8)
{
Console.WriteLine("да");
}
else 
Console.WriteLine("Введите число от 1 до 7");