// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int [rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// int [,] SortRowsMinMax(int [,] array)
// {
//     int imin = 0, jmin = 0;
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//         for (int x = 0; x < array.GetLength(1); x++)
//         {
//             for(int j = 0; j<array.GetLength(1)-1; j++)
//             {
//                 if(array[i,j+1]<array[i,j])
//                 {
//                     int temp = array[i,j];
//                     array[i,j] = array[i,j+1];
//                     array[i,j+1] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// Console.WriteLine("Enter row: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// int [,] changeArray = SortRowsMinMax(array);
// Console.WriteLine();
// Show2dArray(changeArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int [rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// void RowLowSum(int [,] array)
// {
//     int temp = 1000;
//     int n = 0;
//     for(int i = 0; i<array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for(int j = 0; j<array.GetLength(1); j++)
//         {
//             sum = sum + array[i,j];
        
//         } 
//         if (temp > sum)
//         { 
//             temp = sum;
//             n = i+1;
//         } 
//         Console.WriteLine(sum);
        
//     }
//     Console.WriteLine();
//     Console.Write($"{n}");
    
// } 


// Console.WriteLine("Enter row: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter cols: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max: ");
// int max = Convert.ToInt32(Console.ReadLine());
// int [,] array = CreateRandom2dArray(rows,cols,min,max);
// Show2dArray(array);
// RowLowSum(array);


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] CreateRandom2dArray(int rows, int cols, int min, int max){
//     int[,] array = new int [rows,cols];
//     for(int i = 0; i<rows; i++)
//         for(int j = 0; j<cols; j++)
//             array[i,j] = new Random().Next(min, max+1);
//     return array;
// }

// void Show2dArray(int[,] array){
//     for(int i = 0; i<array.GetLength(0); i++){
//         for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write(array[i,j]+ " ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] Prod2Matr(int [,] array1, int [,] array2)
// {
//     int[,] matr = new int [array1.GetLength(0), array1.GetLength(1)];
//     for(int i = 0; i<array1.GetLength(0); i++)
//     {
        
//         for(int j = 0; j<array1.GetLength(1); j++)
//         {
//            matr[i,j] = array1[i,0]*array2[0,j]+array1[i,1]*array2[1,j];   
//         }
//     }
//     return matr;
// }

// Console.WriteLine("Enter row1: ");
// int rows1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter cols1: ");
// int cols1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min1: ");
// int min1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max1: ");
// int max1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Enter row2: ");
// int rows2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter cols2: ");
// int cols2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter min2: ");
// int min2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter max2: ");
// int max2 = Convert.ToInt32(Console.ReadLine());

// int [,] array1 = CreateRandom2dArray(rows1,cols1,min1,max1);
// Show2dArray(array1);
// Console.WriteLine();
// int [,] array2 = CreateRandom2dArray(rows2,cols2,min2,max2);
// Show2dArray(array2);
// Console.WriteLine();
// int [,] matr = Prod2Matr(array1, array2);
// Show2dArray(matr);


// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// int[,,] CreateRandom3dArray(int rows, int cols, int z){
//     int[,,] array = new int [rows,cols,z];
//     for(int k = 0; k<z; k++)
//         for(int i = 0; i<rows; i++)
//             for(int j = 0; j<cols; j++)
//             array[i,j,k] = new Random().Next(10, 100);
//     return array;
// }

// void Show3dArray(int[,,] array){
//     for(int k = 0; k<array.GetLength(2); k++){
//         for(int i = 0; i<array.GetLength(0); i++){
//             for(int j = 0; j<array.GetLength(1); j++){
//             Console.Write($"{array[i,j,k]}({i},{j},{k}) ");
//             }
//         Console.WriteLine();
//         }
//     }
// }

// int rows = 2;
// int cols = 2;
// int z = 2;
// int [,,] array = CreateRandom3dArray(rows,cols,z);
// Show3dArray(array);


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
