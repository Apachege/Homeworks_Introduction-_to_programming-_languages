// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.(Math.Pow использовать нельзя!!!)
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// void Exponentation (int a, int b){
//     int c = 1;
//     for (int i = 0; i < b; i++){
//         c = c * a;
        
//     }
//     Console.WriteLine($"The number {a} to the power of {b} equals {c}");
// }

// Console.WriteLine("Enter base");
// int bas = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter exponent");
// int exp = Convert.ToInt32(Console.ReadLine());
// Exponentation(bas, exp);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int Amount (int num){
//     int sum = 0;
//     for (int i = 0; num > 0; i++){
//         sum = sum + num%10;
//         num = num/10;
//     }
//     return sum;
// }

// Console.WriteLine("Enter number");
// int number = Convert.ToInt32(Console.ReadLine());
// int summ = Amount(number);
// Console.WriteLine($"Sum of digits in the number {number} is {summ}");


// Задача 29: Напишите программу, которая задаёт массив из произвольного кол-ва элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// int [] Array(int size){
//     int [] arr = new int [size];
//     for (int i = 0; i < size; i++){
//         Console.Write("Enter number ");
//         arr[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return arr;
// }

// void PrintArray (int[] arr){
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }

// Console.WriteLine("Enter array length");
// int length = Convert.ToInt32(Console.ReadLine());
// PrintArray(Array(length));