//Задача 64: Написать рекурсивную функцию перевода из десятичной системы исчисления в двоичную.

// void DecToBin (int numb)
// {
//     if(numb>1)
//     DecToBin (numb/2);
//     Console.Write(numb%2);
// }

// Console.WriteLine("Enter number: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// DecToBin(numb);


// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// int SumNatNum (int n, int m)
// {
//     if(Math.Max(n,m) > Math.Min(n,m)) 
//     return SumNatNum(Math.Max(n,m),Math.Min(n,m)+1) + Math.Min(n,m);
//     else if (Math.Max(n,m) == Math.Min(n,m)) return Math.Max(n,m);
//     else return 0;
// }

// Console.WriteLine("Enter first number: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int number2 = Convert.ToInt32(Console.ReadLine());
// int sum = SumNatNum(number1, number2);
// Console.Write(sum);


// void SumNat (int n, int m)
// {   
//     if(Math.Max(n,m) != Math.Min(n,m)) {
//     SumNat(Math.Max(n,m),Math.Min(n,m)+1);}
//     int temp=Math.Min(n,m)+Math.Min(n,m);
//     Console.Write(temp);
    
// }

// // int nat = SumNat(4,8);
// // Console.WriteLine(nat);
// SumNat(1,15);



