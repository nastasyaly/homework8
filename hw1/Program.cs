//Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

int[,] CreateMatr(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for(int i = 0;  i < matrix.GetLength(0); i++)
    {
            for(int j = 0;  j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(1,100);
            }
    }
    return matrix;
}

void PrintMatr(int[,] matr)
{
        for(int i = 0;  i < matr.GetLength(0); i++)
        {
                        for(int j = 0;  j < matr.GetLength(1); j++)
                        {
                            Console.Write(matr[i, j] +  "\t");
                        }
                        Console.WriteLine();
        }
}

int [,] NewMatrix = CreateMatr(4,5);
PrintMatr(NewMatrix);

 void SortHighestValue(int[,] matr1)
 {
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(1) - 1; k++)
            {
                if (matr1[i, k] < matr1[i, k + 1])
                {
                    int temp = matr1[i, k + 1];
                    matr1[i, k + 1] = matr1[i, k];
                    matr1[i, k] = temp;
                }
            }
        }
    }
                    
    }
 
 SortHighestValue(NewMatrix);
 Console.WriteLine();
 PrintMatr(NewMatrix);