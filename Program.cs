// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double[,] Create2DRandomArray(int colums, int rows)
// {
//     double[,] newArray = new double[rows, colums];
//     Random rand = new Random();

//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < colums; j++)
//         {
//             newArray[i, j] = (double)rand.Next(-90, 100) / 10;
//         }
//     }

//     return newArray;
// }

// void Show2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Input number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input minimal value of array element");

// double[,] array = Create2DRandomArray(columns, rows);

// Show2DArray(array);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// int m =3;
// int n = 3;
// int [,] arr = new int [m,n];
// Console.WriteLine ("Input number");
// int number = Convert.ToInt32(Console.ReadLine());
// FillArray (arr);
// FindElementArray (arr, number);

// void FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(1,10);
//             Console.Write(arr [i, j] +" ");
//         }
//         Console.WriteLine();
//     }
   
// }

// void FindElementArray(int[,] array, int usernumber)
// {
//     bool find = false;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (array[i, j] == usernumber)
//             {
//                 Console.WriteLine ("Ваше значение находится по координатам " + i +" " + j);
//                 find = true;
//             }
//         }
//     }
//     if (find == false)
//     Console.WriteLine ("Такого значения нет"); 
// }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// Console.WriteLine("Input number of rows");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Input number of columns");
// int m = Convert.ToInt32(Console.ReadLine());

// int[,] array = new int[n, m];
// FillArrayRandomNumbers(array);


// for (int j = 0; j < array.GetLength(1); j++)
// {
//     double avarage = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         avarage = (avarage + array[i, j]);
//     }
//     avarage = avarage / n;
//     Console.Write(avarage + "; ");
// }
// Console.WriteLine();
// MyArray(array);

// void FillArrayRandomNumbers(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 10);
//         }
//     }
// }

// void MyArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write(" ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.Write(" ");
//         Console.WriteLine(" ");
//     }
// }

