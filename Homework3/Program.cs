// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// void Palindrome (int N) {
//     int a = N/10000;
//     int b = (N-a*10000)/1000;
//     int d = N%100/10;
//     int e = N%10;
//     if (a==e && b==d) Console.WriteLine("Number is palindrome");
//     else Console.WriteLine("Number isn't palindrome");
// }

// Console.WriteLine("Enter five-digit number");
// int num = Convert.ToInt32(Console.ReadLine());

// Palindrome(num);


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// void Dist (int x1, int y1, int z1, int x2, int y2, int z2) {
//     double d = Math.Sqrt(Math.Pow((x2-x1),2)+Math.Pow((y2-y1),2)+Math.Pow((z2-z1),2));
//     Console.WriteLine($"Distance: {Math.Round(d,2)}");
// }

// Console.WriteLine("Enter x1: ");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y1: ");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter z1: ");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter x2: ");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter y2: ");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter z2: ");
// int z2 = Convert.ToInt32(Console.ReadLine());

// Dist(x1, y1, z1, x2, y2, z2);


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// void Table (int number)
// {
//     for (int num = 1; num <= number; num++)
//     {
//         Console.Write(num*num*num + " ");
//     }
// }
// Console.WriteLine("Please, write number");
// int N = Convert.ToInt32(Console.ReadLine());
// Table(N);