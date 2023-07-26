 //Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
  //Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)

int[,,] CreateMatr(int m, int n, int l) 
{
     int[,,] matr = new int[m, n, l];
     for(int i = 0; i < matr.GetLength(0); i++)
     {
             for(int j = 0; j < matr.GetLength(1); j++)
             {
                for(int k = 0; k < matr.GetLength(2); k++)
                {
                    matr[i,j,k] = new Random().Next(10,100);
                }
    
             }

     }
    
 return matr;
}

void PrintMatr(int[,,] matr1)
{
     for(int i = 0; i < matr1.GetLength(0); i++)
     {
             for(int j = 0; j < matr1.GetLength(1); j++)
             {
                                for(int k = 0; k < matr1.GetLength(2); k++)
                                {
                            Console.Write(matr1[i, j, k] +  "\t");
                                }

             }
                                     Console.WriteLine();

             
}
             }

     

int[,,] NewMAtr = CreateMatr(3,3,3);
PrintMatr(NewMAtr);

void PrintElementIndex(int [,,] matr3)
{
   for(int i = 0; i < matr3.GetLength(0); i++)
     {
             for(int j = 0; j < matr3.GetLength(1); j++)
             {
                                for(int k = 0; k < matr3.GetLength(2); k++)
                                {
                                     Console.Write($"{matr3[i, j, k]}[ {i} , {j} , {k} ] ");
                                                                          Console.WriteLine();


                                }
}
     }
}

PrintElementIndex(NewMAtr);