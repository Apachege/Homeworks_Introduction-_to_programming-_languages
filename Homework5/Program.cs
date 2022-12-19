// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int [] CreateArray (int size, int minValue, int maxValue){
//     int [] array = new int [size];
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }

// void ShowArray (int [] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int EvenNumbers (int [] array){
//     int evennums = 0;
//     for (int i = 0; i < array.Length; i++){
//         if (array[i]%2 == 0) evennums = evennums + 1;
//     }
//     return evennums;
// }

// int size = new Random().Next(2, 10);
// int min = 100;
// int max = 1000;
// int [] arr = CreateArray(size, min, max);
// ShowArray(arr);
// int even = EvenNumbers(arr);
// Console.WriteLine($"The number of even numbers in the array is {even}");



// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

// int [] CreateArray (int size, int minValue, int maxValue){
//     int [] array = new int[size];
//     for (int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }

// void ShowArray (int [] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int NumbersSegment (int [] array, int minSegment, int maxSegment){
//     int numseg = 0;
//     for (int i = 0; i < array.Length; i++){
//         if (array[i] > minSegment-1 && array[i] < maxSegment+1) numseg = numseg + 1;
//     }
//     return numseg;
// }

// int size = 123;
// int minA = 1;
// int maxA = 1000;
// int [] arr = CreateArray(size, minA, maxA);
// ShowArray(arr);
// int minSeg = 10;
// int maxSeg = 99;
// int numSeg = NumbersSegment(arr, minSeg, maxSeg);
// Console.WriteLine($"The number of array elements whose values lie within the interval [{minSeg},{maxSeg}] is {numSeg}");


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// int [] CreateArray (int size, int minValue, int maxValue){
//     int [] array = new int[size];
//     for (int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }

// void ShowArray (int [] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int SumOddIndNum (int [] array){
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++){
//         if (i % 2 == 1) sum = sum + array[i];
//     }
//     return sum;
// }

// int size = new Random().Next(2, 10);
// int min = -99;
// int max = 100;
// int [] arr = CreateArray(size, min, max);
// ShowArray(arr);
// int sumEven = SumOddIndNum(arr);
// Console.WriteLine($"The sum of the elements at odd positions is {sumEven}");


// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// int [] CreateArray (int size, int minValue, int maxValue){
//     int [] array = new int[size];
//     for (int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }

// void ShowArray (int [] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int MinElementArray (int [] array){
//     int min = array[0];
//     for (int i = 1; i < array.Length; i ++){
//         if (array[i] < min) min = array[i];
//     }
//     return min;
// }

// int MaxElementArray (int [] array){
//     int max = array[0];
//     for (int i = 1; i < array.Length; i++){
//         if (array[i] > max) max = array[i];
//     }
//     return max;
// }

// int size = new Random().Next(2, 10);
// int min = 1;
// int max = 100;
// int [] array = CreateArray(size, min, max);
// ShowArray(array);
// int diffMaxMin = MaxElementArray(array) - MinElementArray(array);
// Console.WriteLine($"The difference between the maximum ({MaxElementArray(array)}) and minimum ({MinElementArray(array)}) element of the array is {diffMaxMin}");


// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// int [] CreateArray (int size, int minValue, int maxValue){
//     int [] array = new int[size];
//     for (int i = 0; i < array.Length; i++){
//         array[i] = new Random().Next(minValue, maxValue);
//     }
//     return array;
// }

// void ShowArray (int [] array){
//     for (int i = 0; i < array.Length; i++){
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// int [] ProductNumArr (int [] array){
//     int size = 0;
//     if (array.Length%2 == 0) size = array.Length/2;
//     else size = array.Length/2 + 1;
//     int [] arr = new int [size];
//     int a = array.Length - 1;
//     for (int i = 0; i < array.Length/2; i++){
//         arr[i] = array[i] * array[a];
//         a = a - 1;
//     }
//     if (array.Length%2 == 1) arr[array.Length/2] = array[array.Length/2];
//     return arr;
// }


// int size = new Random().Next(2, 10);
// int min = 1;
// int max = 10;
// int [] array = CreateArray(size, min, max);
// ShowArray(array);
// int [] prodarr = ProductNumArr(array);
// ShowArray(prodarr);