//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double [,] CreateRandomArray(int rows,int columns,int minValue,int maxValue)
{
  double [,] array = new double[rows,columns];
    for(int i =0; i < rows; i++)
      for(int j = 0; j < columns; j++)
      {
        array[i,j] = new Random().Next(minValue, maxValue);
        array[i,j] += new Random().NextDouble();
      }
    return array; 
}
void Show2dArray(double[,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      Console.Write(Math.Round(array[i,j],1) + " ");

    Console.WriteLine();
  }
  Console.WriteLine();
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] newArray = CreateRandomArray(rows, columns, minValue,maxValue);
Show2dArray(newArray);
*/
//=================================================================
//Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет
/*
int[,] CreateRandomArray(int rows,int columns,int minValue,int maxValue)
{
  int [,] array = new int[rows,columns];
    for(int i =0; i < rows; i++)
      for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue+1);
    return array; 
}
void Show2dArray(int[,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");

    Console.WriteLine();
  }
  Console.WriteLine();
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateRandomArray(rows, columns, minValue,maxValue);
Show2dArray(newArray);

void PresenceElementArray(int index1, int index2, int [,] array)
{ 
  if(index1 < 0|| index2 < 0 || index1 >= rows|| index2 >= columns)
    Console.WriteLine("The element with these indexes is missing");
  else 
    Console.WriteLine($"Array element = {array[index1,index2]}");
  return;   
} 
Console.Write("Enter the rows index: ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the columns index: ");
int index2 = Convert.ToInt32(Console.ReadLine());

PresenceElementArray(index1, index2, newArray);
*/
//==================================================
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
/*
int[,] CreateRandomArray(int rows,int columns,int minValue,int maxValue)
{
  int [,] array = new int[rows,columns];
    for(int i =0; i < rows; i++)
      for(int j = 0; j < columns; j++)
        array[i,j] = new Random().Next(minValue, maxValue+1);
    return array; 
}
void Show2dArray(int[,] array)
{
  for(int i =0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j< array.GetLength(1); j++)
      Console.Write(array[i,j] + " ");

    Console.WriteLine();
  }
  Console.WriteLine();
}
double AverageColumns(int j, int[,] array)
{
  double sum = 0;
  
  for( int i= 0; i < array.GetLength(0); i++)
  {
    sum = sum + array[i,j];
  }
  return sum/array.GetLength(0); 
}
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int [,] newArray = CreateRandomArray(rows, columns, minValue,maxValue);
Show2dArray(newArray);
Console.Write("Arithmetic mean of the column: ");
for(int j = 0; j < columns; j++)
  Console.Write(Math.Round(AverageColumns(j,newArray),2) +"; ");
  */







