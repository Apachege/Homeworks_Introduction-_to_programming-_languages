// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double [,] Create2dArrayDouble (int rows, int cols){
//     double [,] array = new double [rows, cols];
//     for (int i = 0; i < rows; i++){
//         for (int j = 0; j < cols; j++){
//             array[i, j] = new Random().NextDouble()*10;
//         }
//     }
//     return array;
// }

// void Show2Array (double [,] array){
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// double [,] array = Create2dArrayDouble (m, n);
// Show2Array(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int [,] Create2dArray(int rows, int cols, int min, int max){
//     int [,] array = new int [rows, cols];
//     for(int i=0; i<rows; i++){
//         for(int j=0; j<cols; j++){
//             array[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }

// void Show2Array(int[,] array){
//     for(int i=0; i<array.GetLength(0); i++){
//         for(int j=0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// void ValueForIndex(int [,] array, int row, int col){
//     if (row > array.GetLength(0) || col > array.GetLength(1)) Console.WriteLine("No such number in the array");
//     else Console.WriteLine(array[row-1, col-1]);           
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min elem: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max elem: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = Create2dArray(m,n,min,max);
// Show2Array(array);
// Console.Write("Enter row number: ");
// int row = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter column number: ");
// int col = Convert.ToInt32(Console.ReadLine());
// ValueForIndex(array, row, col);


// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// int [,] Create2dArray(int rows, int cols, int min, int max){
//     int [,] array = new int [rows, cols];
//     for(int i=0; i<rows; i++){
//         for(int j=0; j<cols; j++){
//             array[i,j] = new Random().Next(min,max+1);
//         }
//     }
//     return array;
// }

// void Show2Array(int[,] array){
//     for(int i=0; i<array.GetLength(0); i++){
//         for(int j=0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+" ");
//         }
//         Console.WriteLine();
//     }
// }

// void ArithmeticMean(int [,] array){
//     for(int j=0; j<array.GetLength(1); j++){
//         double arithMean = 0;
//         for(int i=0; i<array.GetLength(0); i++){
//             arithMean = arithMean + array[i,j];
//         }
//         arithMean = arithMean/array.GetLength(0);
//         Console.Write($"{arithMean} ");
//     }
// }

// Console.Write("Enter numb of rows: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of cols: ");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of min elem: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter numb of max elem: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = Create2dArray(m,n,min,max);
// Show2Array(array);
// ArithmeticMean(array);