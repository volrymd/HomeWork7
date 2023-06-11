// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

void InputMatrix (int [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix [i,j] = new Random().Next(-100,101);
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

string FindPosition (int [,] matrix, int [] find)
{
    string result = "Такого элемента нет";
    for (int i=0; i<matrix.GetLength(0);i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (i == find[0]-1 && j == find[1]-1)
                    {
                        result = matrix[i,j].ToString();  
                        break;      
                    }                        
            }
    }
    return result;
}

Console.Clear ();
Console.WriteLine ("Введите размеры массива: ");
int [] size = Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
int [,] matrix = new int [size[0], size[1]];
Console.WriteLine ("Введите искомую позицию: ");
int [] find = Console.ReadLine()!.Split().Select(x=>int.Parse(x)).ToArray();
InputMatrix (matrix);
PrintMatrix (matrix);
Console.WriteLine();
Console.WriteLine($"{FindPosition (matrix, find)}");
