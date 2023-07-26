//задача Задача 58: Задайте две матрицы. 
//Напишите программу, которая будет находить
// произведение двух матриц.

int[,] CreateMatr(int m, int n)
 {
    int[,] matr1 = new int[m,n];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i,j] = new Random().Next(1,10);
        }
    }
        return matr1;   
 }

    
    
    
    int columns = 3;
    int rows = 3;
    int[,] FirstMatrix = CreateMatr(rows, columns);
    int columns1 = 3;
    int rows1 = 3;
    int[,] SecondMatrix = CreateMatr(rows1, columns1);



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
PrintMatr(FirstMatrix);
Console.WriteLine();
PrintMatr(SecondMatrix);
Console.WriteLine();


int[,] MultipleMatrix(int rows, int columns, int[,] matr2, int[,] matr3)
{
    int[,] NewMatr = new int[rows,columns];
    for(int i = 0;  i < matr2.GetLength(0); i++)
    {
            for(int j = 0;  j < matr2.GetLength(0); j++)
            {
                NewMatr[i,j] = matr2[i,j] * matr3[i,j];
            }

    }
    return NewMatr;
}
                
     

int[,] FinalMatrix = MultipleMatrix(3, 3, FirstMatrix, SecondMatrix);
PrintMatr(FinalMatrix);