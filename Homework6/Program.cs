// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// void CountEven (int [] array){
//     int count = 0;
//     for(int i = 0; i < array.Length; i++){ 
//         if (array[i]>0) count++;
//     }
//     Console.WriteLine($"The number of positive numbers is {count}");
// }

// int [] TransformArray (int m){
//     int [] array = new int[m];
//     for(int i = 0; i < m; i++){
//         Console.Write("Enter number: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// Console.Write("Enter the number of numbers: ");
// int m = Convert.ToInt32(Console.ReadLine());
// int [] array = TransformArray(m);
// CountEven(array);


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// void LineIntersection (double b1, double k1, double b2, double k2){
//     double x = (b2 - b1)/(k1 - k2);
//     double y = k1*x + b1;
//     Console.WriteLine($"Line intersection point: ({x}, {y})");
// }

// Console.Write("Enter first point of first line: ");
// double b1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter first point of second line: ");
// double k1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second point of first line: ");
// double b2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter second point of second line: ");
// double k2 = Convert.ToInt32(Console.ReadLine());
// LineIntersection(b1, k1, b2, k2);