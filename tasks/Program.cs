   /*                          Задача 47
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9


double[,] FillArray(int a, int b)
{
    double[,] Array = new double[a, b];

    Random random = new Random();
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Array[i, j] = Math.Round(random.Next(-9, 9) + random.NextDouble(),2);
        }
    }
    return Array;
}

void Print2XArray(double[,] Array)
{
    int rows = Array.GetUpperBound(0)+1;
    int columns = Array.GetUpperBound(1)+1;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
             Console.Write($"{Array[i, j]}  \t");
        }
        Console.WriteLine();
    }
}
 double [,] array = FillArray(5, 3);
 Print2XArray(array);

                                
                                
                                Задача 50
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
           

int[,] FillArray(int a, int b)
{
    System.Console.WriteLine("Массив:");
    Random random = new Random();
    int[,] Array = new int[a, b];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            Array[i, j] = random.Next(100, 999);
            System.Console.Write($"{Array[i, j]} \t");
        }
        System.Console.WriteLine();
    }
    return Array;
}

System.Console.Write("Задайте количество строк массива: ");
int RowsCount = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Задайте количество колонок массива: ");
int ColumnsCount = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер строки искомого элемента: ");
int RowNumber = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите номер столбца искомого элемента: ");
int ColumnNumber = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(RowsCount, ColumnsCount);

if (RowNumber < 0 | RowNumber > RowsCount |
ColumnNumber < 0 | ColumnNumber > ColumnsCount)
{
    Console.WriteLine("Элемент не существует");
}
else
{
    Console.WriteLine("Значение искомого элемента массива = {0}", array[RowNumber - 1, ColumnNumber - 1]);
}



                                Задача 52
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов
в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.Write("Введите размерность m массива: ");
int ArrowsCount = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размерность n массива: ");
int ColumnCount = Convert.ToInt32(Console.ReadLine());
int[,] randomArray = new int[ArrowsCount, ColumnCount];



void mas(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1, 9);
            Console.Write($"{randomArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void arif(int m, int n)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    int k, g;

    for (k = 0; k < n; k++)
    {
        double sum = 0;
        for (g = 0; g < m; g++)
        {
            sum = sum + randomArray[g, k];
        }
        Console.Write($"{sum / (g):F1}; ");
    }
}

mas(ArrowsCount, ColumnCount);
arif(ArrowsCount, ColumnCount);
*/