//Задача 56: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

 int[,] CreateMatr(int m, int n)
 {
    int[,] matr1 = new int[m,n];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            matr1[i,j] = new Random().Next(1,100);
        }
    }
        return matr1;   
 }

    
    
    
    int columns = 3;
    int rows = 3;
    int[,] NewMatrix = CreateMatr(rows, columns);

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
PrintMatr(NewMatrix);
Console.WriteLine();

    int min = int.MaxValue;
    int indexMinRow = 0;
    int RowSum = 0;

    for(int i = 0; i < NewMatrix.GetLength(0); i++)
    {
      for(int j = 0; j < NewMatrix.GetLength(1); j++)
      {
       RowSum = NewMatrix[i,j] + RowSum;

      }
       if(min > RowSum)
       {
        min = RowSum;
        indexMinRow = i;

       }
              Console.WriteLine($"сумма в строчке {i} =  {RowSum}");

    }
              Console.WriteLine($"наименьшая сумма в строчке: {min}");

          Console.WriteLine($"наименьшая сумма элементов в строчке: {indexMinRow + 1}");

    
    
        
        

