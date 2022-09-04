// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] mone = {{2,4},
               {3,2}};

int[,] mtwo = {{3,4},
               {3,3}};

int[,] mthree = new int[mone.GetUpperBound(0) + 1,mone.GetUpperBound(0) + 1];

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void Umnoj(int[,] mone, int[,] mtwo, int[,] mthree)
{
    for(int i = 0; i <mthree.GetLength(0); i++)
    {
        for(int j = 0; j < mthree.GetLength(1); j++)
        {
            int res = 0;
            for(int x = 0; x < mone.GetLength(1); x++)
            {
                res = res + (mone[i, x] * mtwo[x, j]);
            }
            mthree[i, j] = res;
        }
    }
}

PrintArray(mone);
Console.WriteLine();

PrintArray(mtwo);
Console.WriteLine();

Umnoj(mone, mtwo, mthree);
Console.WriteLine("Произведение матриц ");
Console.WriteLine();
PrintArray(mthree);