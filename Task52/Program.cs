// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(0,101);
            }
        } 
}

void PrintMatrix (int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(0);i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i,j]}\t");
            }
            Console.WriteLine();
    }
}

void FindMean (int [,] matrix)
{
    for (int i=0; i<matrix.GetLength(1);i++)
    {
        double mean = 0;
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
            {
                sum = sum + matrix[j,i];                    
            }
        mean = Math.Round(sum / matrix.GetLength(0), 2);
        Console.WriteLine (mean);       
    }
}

Console.Clear ();
Console.WriteLine ("Введите размеры массива: ");
int [] size = Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int [,] matrix = new int [size[0], size[1]];
InputMatrix (matrix);
PrintMatrix (matrix);
Console.WriteLine("Среднее арифметическое каждого столбца: ");
FindMean (matrix);
